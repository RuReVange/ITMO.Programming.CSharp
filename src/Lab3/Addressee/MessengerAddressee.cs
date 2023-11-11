using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class MessengerAddressee : IAddressee
{
    private Messenger _messenger;

    public MessengerAddressee(Messenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMsg(Message message)
    {
        _messenger.AddMsg(message);
    }
}