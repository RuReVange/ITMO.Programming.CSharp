using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class ConnectLocalModeParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        if (commandContext?.CommandNameAndAtributes == null) return;
        ICommand command = new ConnectCommand(commandContext.CommandNameAndAtributes);
        command.Execute();
    }
}