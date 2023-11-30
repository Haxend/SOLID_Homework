using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings _settings;

            do
            {
                Console.WriteLine("Введите через пробел\n- минимальное значение числа" +
                                  "\n- максимальное значение числа\n- максимальное количество попыток\n" +
                                  $"Например \"0 10 3\".");
                string input = Console.ReadLine();
                _settings = ValidateValue.ParseSettingsOnNull(input);
            }
            while (_settings == null);

            Message _message = new Message();
            NumberGuesser guesser = new NumberGuesser(_settings, _message, new Generator(), new Checker());
            
            guesser.Start();
            Console.WriteLine("Нажмите Enter, чтобы завершить работу программы.");
            Console.ReadLine();
        }
    }
}