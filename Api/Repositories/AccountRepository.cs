using ChallengeApi.DataModel;
using ChallengeApi.DataModel.Interfaces;

namespace ChallengeApi.Api.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IExampleData _data;

        public AccountRepository(IExampleData accountData)
        {
            _data = accountData;
        }

        public Account? FindAccount(int accountId)
        {
            throw new NotImplementedException();
        }
    }
}