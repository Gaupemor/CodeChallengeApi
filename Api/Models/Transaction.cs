/**
*
*   Don't make changes to this file
*
*/

namespace ChallengeApi.Models
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public int AccountId  { get; set; }
        public decimal Amount {get; set; }
        public TransactionType TransactionType { get; set; }
    }
}