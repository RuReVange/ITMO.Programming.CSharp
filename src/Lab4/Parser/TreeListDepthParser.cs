using System;
using System.Collections.Generic;
using System.Globalization;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class TreeListDepthParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext?.FlagDictionary == null) return;
        foreach (KeyValuePair<string, string> item in commandContext.FlagDictionary)
        {
            if (item.Key == "-d")
            {
                ICommand command = new TreeListCommand(int.Parse(item.Value, provider: new NumberFormatInfo()));
                command.Execute();
                Console.WriteLine(Context.ResultCommandString);
            }
        }
    }
}