using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.Services;

namespace ParserInfrastructure.Parser;

public class AddRegularUserParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        var adminServices = new AdminServices();
        adminServices.AddRegularUser(commandContext);
    }
}