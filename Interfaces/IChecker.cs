using System;

namespace HomeworkSOLID.Interfaces
{
    public interface IChecker
    {
        public void SetHiddenNumber(int hiddenNumber);
        public int ChechValue(int inputValue);
    }
}
