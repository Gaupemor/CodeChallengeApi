using ChallengeApi.DataModel;
using ChallengeApi.DataModel.Interfaces;

namespace ChallengeApi.Api.Repositories
{
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