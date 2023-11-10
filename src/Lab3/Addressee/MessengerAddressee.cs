using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class MessengerAddressee : IConcreteAddressee
{
    private Messenger _messenger;

    public MessengerAddressee(Messenger messenger)
    {
        _messenger = messenger;
    }

    public int PossibleImportanceLevel { get; init; } = 2;

    public void SendMsg(Message message, Func<int, int, bool>? func)
    {
        if (message != null && func != null && func(message.ImportanceLevel, PossibleImportanceLevel))
        {
            _messenger.AddMsg(message);
        }
    }
}