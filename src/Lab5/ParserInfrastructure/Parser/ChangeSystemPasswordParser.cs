using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class ChangeSystemPasswordParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var adminServices = new AdminServices();
        adminServices.ChangeSystemPassword(commandContext);
    }
}