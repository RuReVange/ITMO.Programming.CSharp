using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public interface IParser
{
    public void Parse(CommandContext commandContext);
}