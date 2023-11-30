using HomeworkSOLID.Interfaces;
using System;

namespace HomeworkSOLID
{
    public class Settings : ISettings
    {
        public Settings(int minRange, int maxRange, int maxAttemptsCount)
        {
            MaxAttemptCount = maxAttemptsCount;
            MinRange = minRange;
            MaxRange = maxRange;
        }

        public int MaxAttemptCount { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
    }
}
