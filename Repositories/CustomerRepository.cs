using ChallengeApi.Data;
using ChallengeApi.Models;

namespace ChallengeApi.Repositories
{
    public interface ICustomerRepository
    {
        Customer? FindCustomer(string customerId);
    }

    public class CustomerRepository : ICustomerRepository
    {
        private readonly IExampleData _data;

        public CustomerRepository(IExampleData customerData)
        {
            _data = customerData;    
        }
        
        public Customer? FindCustomer(string customerId)
        {
            return _data.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
    }
}