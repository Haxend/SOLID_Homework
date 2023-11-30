using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    public class Controller
    {
        private IAttemptCounter _counter;
        private IChecker _checker;


        public event Action<int> OnMatch;
        public event Action<int> OnLower;
        public event Action<int> OnHigher;
        public event Action OnNoAttemptLeft;

        public Controller(IAttemptCounter counter, IChecker checker)
        {
            _counter = counter;
            _checker = checker;
            _counter.OnNoAttemptLeft += () => OnNoAttemptLeft();
        }

        public void DoIteration(int currentAttempt)
        {
            int result = _checker.ChechValue(currentAttempt);


            if (result == 0) OnMatch(currentAttempt);
            else if (result == -1) OnLower(currentAttempt);
            else OnHigher(currentAttempt);

            _counter.AttemptDecrease();
        }
    }
}
