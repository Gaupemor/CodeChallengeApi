namespace ChallengeApi.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public List<int> AccountIds { get; set; }
    }
}