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
            var customers = _data.Customers;
            foreach (var customer in customers)
            {
                if (customer.CustomerId == customerId)
                {
                    return customer;
                }
            }

            return null;
        }
    }
}