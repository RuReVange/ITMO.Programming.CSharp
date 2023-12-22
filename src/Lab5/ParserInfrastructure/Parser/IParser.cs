using ApplicationCore.Models.DomainModels;

namespace ParserInfrastructure.Parser;

public interface IParser
{
    public void Parse(CommandContext commandContext);
}