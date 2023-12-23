using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class RefillAccountParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var userServices = new RegularUserServices();
        int tmp = userServices.RefillAccount(commandContext);
        Console.WriteLine(tmp);
        commandContext.ResultValue = tmp;
    }
}