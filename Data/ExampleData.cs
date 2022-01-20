using ChallengeApi.Models;

namespace ChallengeApi.Data 
{
    public interface IExampleData
    {
        List<Customer> Customers { get; set; }
        List<Account> Accounts { get; set; }
    }

    public class ExampleData : IExampleData
    {
        public List<Customer> Customers { get; set; }
        public List<Account> Accounts { get; set; }
        
        public ExampleData()
        {
            // Instantiate with a default customer and some accounts
            Customers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = "1",
                    AccountIds = new List<int> { 1000, 1001 }
                }
            };

            Accounts = new List<Account>
            {
                new Account
                {
                    AccountId = 999,
                    AccountBalance = 1000.73m
                },
                new Account
                {
                    AccountId = 1000,
                    AccountBalance = 500.64m
                },
                new Account
                {
                    AccountId = 1001,
                    AccountBalance = 250.25m
                },
                new Account
                {
                    AccountId = 1002,
                    AccountBalance = 330.00m
                }
            };
        }
    }
}