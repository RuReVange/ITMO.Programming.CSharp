using ApplicationCore.Models.DomainModels;

namespace ParserInfrastructure.Parser;

public class ShowLogHistoryParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        foreach (KeyValuePair<string, IParser> item in Context.ShowLogHistoryFlagsDictionary)
        {
            if (commandContext?.FlagDictionary != null && commandContext.FlagDictionary.ContainsKey(item.Key))
            {
                item.Value.Parse(commandContext);
            }
        }
    }
}