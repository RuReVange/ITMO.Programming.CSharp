using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class FileShowModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        foreach (KeyValuePair<string, IParser> item in Context.FileShowCommandModesDictionary)
        {
            if (commandContext?.FlagDictionary != null && commandContext.FlagDictionary.ContainsValue(item.Key))
            {
                item.Value.Parse(commandContext);
            }
        }
    }
}