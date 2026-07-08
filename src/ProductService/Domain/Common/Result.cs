namespace Domain.Common
{
    public class Result
    {
        public bool IsFailure { get; set; }

        public IReadOnlyCollection<string> Errors { get; set; }
    }
}
