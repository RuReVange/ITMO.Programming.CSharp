using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public interface IAddressee
{
    void SendMsg(Message message);
    int GetThisPossibleImportanceLevel();
}