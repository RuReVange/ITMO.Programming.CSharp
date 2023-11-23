using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class FileDeleteParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext == null) return;
        commandContext.CommandNameAndAtributes = commandContext.CommandNameAndAtributes?.Trim();

        ICommand command = new FileDeleteCommand(commandContext.CommandNameAndAtributes ?? throw new InvalidOperationException());
        command.Execute();
    }
}