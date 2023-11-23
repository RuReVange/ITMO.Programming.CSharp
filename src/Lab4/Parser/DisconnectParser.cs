using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class DisconnectParser : IParser
{
    public void Parse(CommandContext commandContext)
    {
        ICommand command = new DisconnectCommand();
        command.Execute();
    }
}