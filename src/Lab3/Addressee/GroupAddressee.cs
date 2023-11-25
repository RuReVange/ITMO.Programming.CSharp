using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class GroupAddressee : IAddressee
{
    private IList<IAddressee> _addresseeList;
    public GroupAddressee(IList<IAddressee> addresseeList)
    {
        _addresseeList = addresseeList;
    }

    public void SendMsg(Message message)
    {
        foreach (IAddressee concreteAddressee in _addresseeList)
        {
            concreteAddressee.SendMsg(message);
        }
    }
}