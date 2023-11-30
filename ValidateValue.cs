using HomeworkSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSOLID
{
    public static class ValidateValue
    {

        public static Settings ParseSettingsOnNull(string input)
        {

            if (input == "")
            {
                Console.Clear();
                Console.WriteLine("Ошибка");
                return null;
            }

            int[] value = new int[3];
            try
            {
                var inputArray = input.Split(" ");
                value[0] = int.Parse(inputArray[0]);
                value[1] = int.Parse(inputArray[1]);
                value[2] = int.Parse(inputArray[2]);
                if (CheckAttemptSettingsCorrect(value[2]))
                    return new Settings(value[0], value[1], value[2]);
                else
                    return null;
            }
            catch ( Exception )
            {
                Console.Clear();
                Console.WriteLine("Ошибка");
                return null;
            }
        }

        public static bool TryParse(string input)
        {
            try
            {
                int i = int.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckAttemptSettingsCorrect(int attemptsCounter)
        {
            if (attemptsCounter < 1)
            {
                Console.Clear();
                Console.WriteLine($"Ошибка неверное значение попыток ({attemptsCounter})\n" +
                                   "Количество попыток должно быть больше 0.\n");
                return false;
            }

            return true;
        }
    }
}
