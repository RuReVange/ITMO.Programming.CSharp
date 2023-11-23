using System;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class FileRenameParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext == null) return;
        commandContext.CommandNameAndAtributes = commandContext.CommandNameAndAtributes?.Trim();
        string[] tmp = commandContext.CommandNameAndAtributes?.Split() ?? throw new InvalidOperationException();

        ICommand command = new FileRenameCommand(tmp[0], tmp[1]);
        command.Execute();
    }
}