using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;

public class User
{
    private IList<MsgWithInfo> _msgList = new List<MsgWithInfo>();

    public void AddMsg(Message message)
    {
        _msgList.Add(new MsgWithInfo(message));
    }

    public MsgWithInfo GetMsgWithInfo(int index)
    {
        return _msgList[index];
    }
}