using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class FileShowParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        foreach (KeyValuePair<string, IParser> item in Context.FileShowCommandFlagsDictionary)
        {
            if (commandContext?.FlagDictionary != null && commandContext.FlagDictionary.ContainsKey(item.Key))
            {
                item.Value.Parse(commandContext);
            }
        }
    }
}