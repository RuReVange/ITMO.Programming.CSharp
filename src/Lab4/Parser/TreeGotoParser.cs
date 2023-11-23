using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class TreeGotoParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext?.CommandNameAndAtributes == null) return;
        ICommand command = new TreeGotoCommand(commandContext.CommandNameAndAtributes);
        command.Execute();
    }
}