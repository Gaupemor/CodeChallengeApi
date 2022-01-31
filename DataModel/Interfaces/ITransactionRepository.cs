namespace ChallengeApi.DataModel.Interfaces;

public interface ITransactionRepository
{
    public List<Transaction> FindTransactions(int accountId);
}