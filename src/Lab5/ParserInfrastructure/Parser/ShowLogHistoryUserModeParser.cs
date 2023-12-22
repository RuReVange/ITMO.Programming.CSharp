using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class ShowLogHistoryUserModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var userServices = new RegularUserServices();
        userServices.ShowLogHistory(commandContext);
    }
}