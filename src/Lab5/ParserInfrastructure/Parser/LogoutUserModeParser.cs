using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class LogoutUserModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var userServices = new RegularUserServices();
        userServices.Logout();
    }
}