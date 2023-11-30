using System;

namespace HomeworkSOLID.Interfaces
{
    public interface IGenerator
    {
        public int Value { get; }
        public void GenerateNewValue();
        public void SetNewRangeLimits(int newMinValue, int newMaxValue);
    }
}
