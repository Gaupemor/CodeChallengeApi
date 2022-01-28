using NUnit.Framework;
using ChallengeApi.Models;
using ChallengeApi.Controllers;
using ChallengeApi.Repositories;
using ChallengeApi.Data;

namespace Tests;

public class Challenge2_Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Challenge2_Test1()
    {
        ICustomerRepository customerRepository = new CustomerRepository(new ExampleData());
        IAccountRepository accountRepository = new AccountRepository();
        CustomersController customersController = new CustomersController(customerRepository, accountRepository);

        Account? account = customersController.Get("1", 1000);

        Assert.IsNotNull(account);
        Assert.AreEqual("A", account.AccountName);
    }

    [Test]
    public void Challenge2_Test2()
    {
        ICustomerRepository customerRepository = new CustomerRepository(new ExampleData());
        IAccountRepository accountRepository = new AccountRepository();
        CustomersController customersController = new CustomersController(customerRepository, accountRepository);

        Account? account = customersController.Get("1", 1001);

        Assert.IsNotNull(account);
        Assert.AreEqual("B", account.AccountName);
    }

    [Test]
    public void Challenge2_Test3()
    {
        ICustomerRepository customerRepository = new CustomerRepository(new ExampleData());
        IAccountRepository accountRepository = new AccountRepository();
        CustomersController customersController = new CustomersController(customerRepository, accountRepository);

        Account? account = customersController.Get("1", 1002);

        Assert.IsNull(account);
    }

    [Test]
    public void Challenge2_Test4()
    {
        ICustomerRepository customerRepository = new CustomerRepository(new ExampleData());
        IAccountRepository accountRepository = new AccountRepository();
        CustomersController customersController = new CustomersController(customerRepository, accountRepository);

        Account? account = customersController.Get("-1", 0);

        Assert.IsNull(account);
    }
}