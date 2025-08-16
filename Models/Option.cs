namespace PollingApi.Models
{
    public class Option
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public int PollId
        {
            get; set;
        }
        public int Votes { get; set; } = 0;
    }
}
