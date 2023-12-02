using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class TreeListParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext?.FlagDictionary != null)
        {
            foreach (KeyValuePair<string, IParser> item in Context.TreeListCommandFlagsDictionary)
            {
                if (commandContext.FlagDictionary.ContainsKey(item.Key))
                    item.Value.Parse(commandContext);
            }
        }
        else
        {
            if (commandContext != null) commandContext.Command = new TreeListCommand();
        }
    }
}