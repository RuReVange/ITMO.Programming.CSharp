using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class TreeGotoParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext?.CommandNameAndAtributes == null) return;
        commandContext.Command = new TreeGotoCommand(commandContext.CommandNameAndAtributes);
    }
}