namespace ChallengeApi.DataModel.Interfaces;

public interface IExampleData
{
    List<Customer> Customers { get; set; }
    List<Account> Accounts { get; set; }
    List<Transaction> Transactions { get; set; }
}