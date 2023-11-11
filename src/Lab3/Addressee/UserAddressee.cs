using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class UserAddressee : IAddressee
{
    private User _user;

    public UserAddressee(User user)
    {
        _user = user;
    }

    public void SendMsg(Message message)
    {
        _user.AddMsg(message);
    }
}