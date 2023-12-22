using ApplicationCore.DomainModels;

namespace Abstractions.Repositories;

public interface IRegularUserRepository
{
    RegularUser? FindRegularUser(RegularUser regularUser);
    int ShowAccountBalance(RegularUser regularUser);
    bool WithdrawMoney(int moneyAmount, RegularUser regularUser);
    bool RefillAccount(int moneyAmount, RegularUser regularUser);
    IList<Log> ShowLogHistory(RegularUser regularUser);
}