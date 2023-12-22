using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class LogoutAdminModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var adminServices = new AdminServices();
        adminServices.Logout();
    }
}