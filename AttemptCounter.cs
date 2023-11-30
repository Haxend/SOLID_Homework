using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    public class AttemptCounter : IAttemptCounter
    {
        private int _attemptsLeft;

        public void SetAttemptCount(int currentAttempts)
            => _attemptsLeft = currentAttempts;

        public void AttemptDecrease()
        {
            _attemptsLeft -= 1;
            if (_attemptsLeft < 1) OnNoAttemptLeft();
        }

        public event Action OnNoAttemptLeft;
    }
}
