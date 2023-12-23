using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class WithdrawMoneyParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var userServices = new RegularUserServices();
        int tmp = userServices.WithdrawMoney(commandContext);
        Console.WriteLine(tmp == -1 ? "Not enough money in the account" : tmp);
        commandContext.ResultValue = tmp;
    }
}