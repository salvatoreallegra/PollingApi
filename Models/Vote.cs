namespace PollingApi.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int PollId { get; set; }
        public int OptionId { get; set; }
        public required string UserId { get; set; }
        public DateTime VotedAt { get; set; }
    }
}
