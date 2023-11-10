using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class GroupAddressee : IAddressee
{
    public GroupAddressee(IList<IConcreteAddressee> concreteAddresseesList)
    {
        ConcreteAddresseesList = concreteAddresseesList;
    }

    public IList<IConcreteAddressee> ConcreteAddresseesList { get; init; }

    public void SendMsg(Message message, Func<int, int, bool>? func)
    {
        foreach (IConcreteAddressee concreteAddressee in ConcreteAddresseesList)
        {
            concreteAddressee.SendMsg(message, func);
        }
    }
}