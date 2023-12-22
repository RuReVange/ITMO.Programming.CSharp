using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class ShowAccountBalanceParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var userServices = new RegularUserServices();
        Console.WriteLine(userServices.ShowAccountBalance(commandContext));
    }
}