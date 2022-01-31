namespace ChallengeApi.DataModel.Interfaces;

public interface IAccountRepository
{
    Account? FindAccount(int accountId);
}