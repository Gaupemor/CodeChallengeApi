using NUnit.Framework;
using ChallengeApi.Models;
using ChallengeApi.Controllers;
using ChallengeApi.Repositories;
using ChallengeApi.Data;

namespace Tests;

public class Challenge1_Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Challenge1_Test1()
    {
        ICustomerRepository customerRepository = new CustomerRepository(new ExampleData());
        IAccountRepository accountRepository = new AccountRepository();
        CustomersController customersController = new CustomersController(customerRepository, accountRepository);

        Customer? customer = customersController.Get("1");

        Assert.IsNotNull(customer);
        Assert.AreEqual(2, customer.AccountIds.Count);
    }

    [Test]
    public void Challenge1_Test2()
    {
        ICustomerRepository customerRepository = new CustomerRepository(new ExampleData());
        IAccountRepository accountRepository = new AccountRepository();
        CustomersController customersController = new CustomersController(customerRepository, accountRepository);

        Customer? customer = customersController.Get("-1");

        Assert.IsNull(customer);
    }
}