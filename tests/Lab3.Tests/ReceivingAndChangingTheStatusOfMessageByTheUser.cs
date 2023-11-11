using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class ReceivingAndChangingTheStatusOfMessageByTheUser
{
    [Fact]
    public void ReceivingTheMessageWithUnreadStatus()
    {
        var message = new Message("header", "body", 2);
        var user = new User();
        var topic = new Topic("Topic", new UserAddressee(user));
        topic.SendMsg(message, 3);

        Assert.True(user.GetMsgWithInfo(0).Message.Body == "body" && user.GetMsgWithInfo(0).IsUnread()); // передается по умолчанию как "unread"

        user.GetMsgWithInfo(0).ChangeMsgStatus();
        Assert.True(user.GetMsgWithInfo(0).IsUnread() == false); // изменился статус сообщения с "unread" на "read"

        Assert.Throws<ArgumentException>(() => user.GetMsgWithInfo(0).ChangeMsgStatus()); // при попытке повторной смены статуса сообщения генерится исключение
    }
}