using ChallengeApi.DataModel;
using ChallengeApi.DataModel.Interfaces;

namespace ChallengeApi.Api.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly IExampleData _data;

    public TransactionRepository(IExampleData transactionData)
    {
        _data = transactionData;
    }

    public List<Transaction> FindTransactions(int accountId)
    {
        throw new NotImplementedException();
    }
}
