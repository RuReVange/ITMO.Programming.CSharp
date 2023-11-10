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

    public void SendMsg(Message message)
    {
        _messenger.AddMsg(message);
    }

    public int GetThisPossibleImportanceLevel()
    {
        return PossibleImportanceLevel;
    }
}