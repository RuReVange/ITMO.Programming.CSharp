using System.Collections.Generic;
using System.Text;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.DataContext;

public class CommandContext
{
    public static StringBuilder ResultCommandString { get; } = new StringBuilder();
    public ICommand? Command { get; internal set; }
    public string? CommandNameAndAtributes { get; internal set; }
    public Dictionary<string, string>? FlagDictionary { get; internal set; }
}