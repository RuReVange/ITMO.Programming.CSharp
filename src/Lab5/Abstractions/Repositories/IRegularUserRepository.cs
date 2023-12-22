using ApplicationCore.Models.DomainModels;

namespace Abstractions.Repositories;

public interface IRegularUserRepository
{
    RegularUser? FindRegularUser(int id, string password);
    int ShowAccountBalance(RegularUser regularUser);
    int WithdrawMoney(int moneyAmount, RegularUser regularUser);
    int RefillAccount(int moneyAmount, RegularUser regularUser);
    IList<Log> ShowLogHistory(RegularUser regularUser);
}