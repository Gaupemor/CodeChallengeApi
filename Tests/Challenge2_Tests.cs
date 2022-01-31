using NUnit.Framework;
using ChallengeApi.Api.Controllers;
using ChallengeApi.Api.Repositories;
using ChallengeApi.DataModel;
using ChallengeApi.DataModel.Interfaces;

namespace Tests;

public class Challenge2_Tests
{
    ICustomerRepository _customerRepository;
    IAccountRepository _accountRepository;
    
    [SetUp]
    public void Setup()
    {
        _customerRepository = new CustomerRepository(new ExampleData());
        _accountRepository = new AccountRepository(new ExampleData());
    }

    [Test]
    public void Challenge2_Test1()
    {
        CustomersController customersController = new CustomersController(_customerRepository, _accountRepository);

        Account? account = customersController.Get("1", 1000);

        Assert.IsNotNull(account);
        Assert.AreEqual("A", account.AccountName);
    }

    [Test]
    public void Challenge2_Test2()
    {
        CustomersController customersController = new CustomersController(_customerRepository, _accountRepository);

        Account? account = customersController.Get("1", 1001);

        Assert.IsNotNull(account);
        Assert.AreEqual("B", account.AccountName);
    }

    [Test]
    public void Challenge2_Test3()
    {
        CustomersController customersController = new CustomersController(_customerRepository, _accountRepository);

        Account? account = customersController.Get("1", 1002);

        Assert.IsNull(account);
    }

    [Test]
    public void Challenge2_Test4()
    {
        CustomersController customersController = new CustomersController(_customerRepository, _accountRepository);

        Account? account = customersController.Get("-1", 0);

        Assert.IsNull(account);
    }
}