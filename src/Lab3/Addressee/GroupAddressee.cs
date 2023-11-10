using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class GroupAddressee : IConcreteAddressee
{
    public GroupAddressee(IList<IConcreteAddressee> concreteAddresseesList)
    {
        ConcreteAddresseesList = concreteAddresseesList;
    }

    public IList<IConcreteAddressee> ConcreteAddresseesList { get; init; }

    public int PossibleImportanceLevel { get; init; } = 1;

    public void SendMsg(Message message)
    {
        foreach (IConcreteAddressee concreteAddressee in ConcreteAddresseesList)
        {
            concreteAddressee.SendMsg(message);
        }
    }

    public int GetThisPossibleImportanceLevel()
    {
        return PossibleImportanceLevel;
    }
}