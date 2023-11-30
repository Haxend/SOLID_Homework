using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    public class Message : IMessage
    {
        public void PrintRangeValue(int minRangValue, int maxRangeValue)
        {
            Console.WriteLine($"Загадано число от {minRangValue} до {maxRangeValue}:");
        }

        public void PrintNumberRequest(int attemptsLeft)
        {
            PrintAttemptsLeftCount(attemptsLeft);
            Console.Write("Введите число:\n>>  ");
        }

        private void PrintAttemptsLeftCount(int attemptsLeft)
        {
            Console.WriteLine($"Кол-во попыток {attemptsLeft}");
        }

        public void PrintLowerMessage(int currentAttempt)
        {
            Console.WriteLine($"Ваще число ({currentAttempt}) меньше, чем загаданное.\n");
        }

        public void PrintHigherMessage(int currentAttempt)
        {
            Console.WriteLine($"Ваще число ({currentAttempt}) больше, чем загаданное.\n");
        }

        public void PrintMatchMessage(int currentAttempt)
        {
            Console.WriteLine($"Вы угадали число {currentAttempt}, поздравляем!\n");
        }

        public void PrintOneMoreAttemptMessage(int attemptsLeft)
        {
            Console.Write($"Попробуйте еще раз.");
            PrintNumberRequest(attemptsLeft);
        }

        public void PrintNoAttemptsLeftMessage(int answerValue)
        {
            Console.WriteLine("Отведенное количество попыток закончилось. У вас не получилось угадать число.\n" +
                $"Ответ = {answerValue}\n");
        }

        public void PrintWrongInputValue()
        {
            Console.WriteLine($"Ошибка формата ввода, попробуйте cнова.\n");
        }
    }
}
