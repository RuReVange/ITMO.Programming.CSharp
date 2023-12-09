using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class StartParser : IParser
{
    public void Parse(CommandContext? commandContext)
    {
        foreach (KeyValuePair<string, IParser> item in Context.FirstLevelDictionary)
        {
             if (commandContext?.CommandNameAndAtributes != null && commandContext.CommandNameAndAtributes.StartsWith(item.Key, StringComparison.OrdinalIgnoreCase))
             {
                 commandContext.CommandNameAndAtributes = commandContext.CommandNameAndAtributes?.Replace(item.Key, string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
                 item.Value.Parse(commandContext);
             }
        }
    }
}