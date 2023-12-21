using ApplicationCore.DomainModels;

namespace Abstractions.Repositories;

public interface IRegularUserRepository
{
    int ShowAccountBalance();
    bool WithdrawMoney(int moneyAmount);
    bool RefillAccount(int moneyAmount);
    IList<Log> ShowLogHistory();
}