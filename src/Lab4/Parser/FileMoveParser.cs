using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class FileMoveParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext == null) return;
        commandContext.CommandNameAndAtributes = commandContext.CommandNameAndAtributes?.Trim();
        string[] tmp = commandContext.CommandNameAndAtributes?.Split() ?? throw new InvalidOperationException();

        commandContext.Command = new FileMoveCommand(tmp[0], tmp[1]);
    }
}