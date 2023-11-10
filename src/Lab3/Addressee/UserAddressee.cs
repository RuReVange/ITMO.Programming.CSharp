using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class UserAddressee : IConcreteAddressee
{
    private User _user;

    public UserAddressee(User user)
    {
        _user = user;
    }

    public int PossibleImportanceLevel { get; init; } = 3;

    public void SendMsg(Message message)
    {
        _user.AddMsg(message);
    }

    public int GetThisPossibleImportanceLevel()
    {
        return PossibleImportanceLevel;
    }
}