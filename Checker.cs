using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    public class Checker : IChecker
    {
        protected int _hiddenNumber;

        public int ChechValue(int inputValue)
        {
            return inputValue.CompareTo(_hiddenNumber);
        }

        public void SetHiddenNumber(int hiddenNumber)
        {
            _hiddenNumber = hiddenNumber;
        }
    }
}
