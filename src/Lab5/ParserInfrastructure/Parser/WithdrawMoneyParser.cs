using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class WithdrawMoneyParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var userServices = new RegularUserServices();
        Console.WriteLine(userServices.WithdrawMoney(commandContext));
    }
}