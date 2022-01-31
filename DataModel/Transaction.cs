namespace ChallengeApi.DataModel;   

public class Transaction
{
    public long TransactionId { get; set; }
    public int AccountId  { get; set; }
    public decimal Amount {get; set; }
    public TransactionType TransactionType { get; set; }
}

public enum TransactionType
{
    Interest,
    Other
}
