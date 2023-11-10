using System;
using Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class DisplayAddressee : IConcreteAddressee
{
    private BaseDisplay _display;

    public DisplayAddressee(BaseDisplay display)
    {
        _display = display;
    }

    public int PossibleImportanceLevel { get; init; } = 1;

    public void SendMsg(Message message, Func<int, int, bool>? func)
    {
        if (message != null && func != null && func(message.ImportanceLevel, PossibleImportanceLevel))
        {
            _display.AddMsg(message);
        }
    }
}