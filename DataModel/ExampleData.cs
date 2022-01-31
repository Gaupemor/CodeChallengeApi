using ChallengeApi.DataModel.Interfaces;

namespace ChallengeApi.DataModel;

public class ExampleData : IExampleData
{
    public List<Customer> Customers { get; set; }
    public List<Account> Accounts { get; set; }
    public List<Transaction> Transactions { get; set; }

    // Instantiate with some initial data
    public ExampleData()
    {
        // Customers
        Customers = new List<Customer>
        {
            new Customer
            {
                CustomerId = "1",
                AccountIds = new List<int> { 1000, 1001 }
            }
        };

        // Accounts
        Accounts = new List<Account>
        {
            new Account
            {
                AccountId = 999,
            },
            new Account
            {
                AccountId = 1000,
                AccountName = "A",
                AccountDescription = "The account for A"
            },
            new Account
            {
                AccountId = 1001,
                AccountName = "B",
                AccountDescription = "The account for B"
            },
            new Account
            {
                AccountId = 1002,
            }
        };

        // Transactions
        Transactions = new List<Transaction>
        {
            new Transaction
            {
                TransactionId = 1,
                AccountId = 1000,
                Amount = 100.00m,
                TransactionType = TransactionType.Other 
            },
            new Transaction
            {
                TransactionId = 2,
                AccountId = 1000,
                Amount = 100.00m,
                TransactionType = TransactionType.Other
            },
            new Transaction
            {
                TransactionId = 3,
                AccountId = 1000,
                Amount = 2.64m,
                TransactionType = TransactionType.Interest   
            },
        };
    }
}