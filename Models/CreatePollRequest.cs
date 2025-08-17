namespace PollingApi.Models
{
    public class CreatePollRequest
    {
        public required string Question { get; set; }
        public required List<string> Options { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
