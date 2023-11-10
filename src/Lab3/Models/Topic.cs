using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public class Topic
{
    public Topic(string name, IAddressee addressee)
    {
        Name = name;
        Addressee = addressee;
    }

    public string Name { get; init; }
    public IAddressee Addressee { get; init; }

    public void SendMsg(Message message)
    {
        IAddressee proxy = new AddresseeProxy(Addressee);
        proxy.SendMsg(message);
    }
}