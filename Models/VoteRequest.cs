namespace PollingApi.Models
{
    public class VoteRequest
    {
        public required string UserId { get; set; }
        public int OptionId { get; set; }
    }
}
