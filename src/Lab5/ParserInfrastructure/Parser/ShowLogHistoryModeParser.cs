using ApplicationCore.Models.DomainModels;

namespace ParserInfrastructure.Parser;

public class ShowLogHistoryModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        foreach (KeyValuePair<string, IParser> item in Context.ShowLogHistoryCommandModesDictionary)
        {
            if (commandContext?.FlagDictionary != null && commandContext.FlagDictionary.ContainsValue(item.Key))
            {
                item.Value.Parse(commandContext);
            }
        }
    }
}