using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    public class NumberGuesser
    {
        private readonly ISettings _settings;
        private readonly IMessage _message;
        private readonly IGenerator _generator;
        private readonly IChecker _digitChecker;

        public NumberGuesser(ISettings settings, IMessage messager,
                                IGenerator generator, IChecker digitChecker)
        {
            _settings = settings;
            _message = messager;
            _generator = generator;
            _generator.SetNewRangeLimits(settings.MinRange, _settings.MaxRange);
            _generator.GenerateNewValue();
            _digitChecker = digitChecker;
            _digitChecker.SetHiddenNumber(_generator.Value);
        }

        public void Start()
        {
            int attemptCounter = _settings.MaxAttemptCount;

            AttemptCounter counter = new AttemptCounter();
            counter.SetAttemptCount(attemptCounter);

            Controller controller = new Controller(counter, _digitChecker);

            controller.OnMatch += Controller_OnMatch;
            controller.OnLower += Controller_OnLower;
            controller.OnHigher += Controller_OnHigher;
            controller.OnNoAttemptLeft += Controller_OnNoAttemptLeft;

            string input;
            int attemptValue;
            _operationFinishFlag = false;

            for (; ; )
            {

                _message.PrintRangeValue(_settings.MinRange, _settings.MaxRange);
                _message.PrintNumberRequest(attemptCounter);

                input = Console.ReadLine();

                if (!ValidateValue.TryParse(input))
                {
                    _message.PrintWrongInputValue();
                    continue;
                }

                attemptValue = int.Parse(input);
                controller.DoIteration(attemptValue);

                if (_operationFinishFlag) break;
                attemptCounter--;
            }
        }

        private bool _operationFinishFlag;

        private void Controller_OnMatch(int currentAttempt)
        {
            _message.PrintMatchMessage(currentAttempt);
            _operationFinishFlag = true;
        }

        private void Controller_OnLower(int currentAttempt)
        {
            _message.PrintLowerMessage(currentAttempt);
        }

        private void Controller_OnHigher(int currentAttempt)
        {
            _message.PrintHigherMessage(currentAttempt);
        }

        private void Controller_OnNoAttemptLeft()
        {
            if (_operationFinishFlag == true) return;

            _message.PrintNoAttemptsLeftMessage(_generator.Value);
            _operationFinishFlag = true;
        }
    }
}
