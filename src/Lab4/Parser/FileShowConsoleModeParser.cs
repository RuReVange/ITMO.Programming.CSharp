using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class FileShowConsoleModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext?.CommandNameAndAtributes == null) return;
        ICommand command = new FileShowCommand(commandContext.CommandNameAndAtributes);
        command.Execute();
        Console.WriteLine(Context.ResultCommandString);
    }
}