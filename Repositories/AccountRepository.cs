using ChallengeApi.Models;

namespace ChallengeApi.Repositories
{
    public interface IAccountRepository
    {
        Account? FindAccount(int accountId);
    }

    public class AccountRepository : IAccountRepository
    {
        public Account? FindAccount(int accountId)
        {
            throw new NotImplementedException();
        }
    }
}