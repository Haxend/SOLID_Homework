using System;

namespace HomeworkSOLID.Interfaces
{
    public interface IAttemptCounter
    {
        public void SetAttemptCount(int currentAttempts);
        public void AttemptDecrease();
        public event Action OnNoAttemptLeft;
    }
}
