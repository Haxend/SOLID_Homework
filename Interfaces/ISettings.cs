namespace HomeworkSOLID.Interfaces
{
    public interface ISettings
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int MaxAttemptCount { get; set; }
    }
}
