namespace ChallengeApi.DataModel.Interfaces;

public interface ICustomerRepository
{
    Customer? FindCustomer(string customerId);
}
