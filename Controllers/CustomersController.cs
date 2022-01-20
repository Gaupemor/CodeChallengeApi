using ChallengeApi.Models;
using ChallengeApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeApi.Controllers
{
    [Route("customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;

        public CustomersController(ICustomerRepository customerRepository, IAccountRepository accountRepository)
        {
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        [HttpGet("{customerId}")]
        public Customer Get(string customerId)
        {
            return null;
        }
    }
}