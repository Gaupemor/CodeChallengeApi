using ChallengeApi.DataModel;
using ChallengeApi.DataModel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeApi.Api.Controllers
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
        public Customer? Get(string customerId)
        {
            return null;
        }

        [HttpGet("{customerId}/accounts/{accountId}")]
        public Account? Get(string customerId, int accountId)
        {
            return null;
        }

        [HttpGet("{customerId}/total-balance")]
        public decimal? GetTotalBalance(string customerId)
        {
            return null;
        }
    }
}