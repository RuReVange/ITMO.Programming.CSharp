using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;

public record MsgWithInfo(Message Message)
{
    private string _msgInfo = "unread";

    public bool IsUnread()
    {
        return _msgInfo == "unread";
    }

    public void ChangeMsgStatus()
    {
        _msgInfo = IsUnread() ? "read" : throw new ArgumentException();
    }
}