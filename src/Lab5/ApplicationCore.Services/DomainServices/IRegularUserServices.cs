using ApplicationCore.Models.DomainModels;

namespace ApplicationCore.Services.DomainServices;

public interface IRegularUserServices
{
    bool Login(CommandContext commandContext);
    int ShowAccountBalance(CommandContext commandContext);
    int WithdrawMoney(CommandContext commandContext);
    int RefillAccount(CommandContext commandContext);
    bool ShowLogHistory(CommandContext commandContext);
    void Logout();
}