using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class GroupAddressee : IAddressee
{
    public GroupAddressee(IList<IAddressee> addresseeList)
    {
        AddresseeList = addresseeList;
    }

    public IList<IAddressee> AddresseeList { get; init; }

    public void SendMsg(Message message)
    {
        foreach (IAddressee concreteAddressee in AddresseeList)
        {
            concreteAddressee.SendMsg(message);
        }
    }
}