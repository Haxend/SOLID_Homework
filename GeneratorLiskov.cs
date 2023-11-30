using System;

namespace HomeworkSOLID
{
    public class GeneratorLiskov : Generator
    {
        public GeneratorLiskov(int minValue = 0, int maxValue = 100) : base(minValue, maxValue)
        {
            _random = new Random();
        }
        private Random _random;
        public int GenerateRandomValue(int minValue, int maxValue) => _random.Next(minValue, maxValue + 1);

        public override void GenerateNewValue()
        {
            Value = GenerateRandomValue(_minValue, _maxValue);
        }
    }
}
