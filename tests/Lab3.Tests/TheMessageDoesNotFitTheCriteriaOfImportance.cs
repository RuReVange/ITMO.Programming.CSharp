using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TheMessageDoesNotFitTheCriteriaOfImportance
{
    [Fact]
    public void TestMethod()
    {
        var message = new Message("header", "body", 3);

        var mock = new Mock<User>();
        var proxy = new AddresseeFilterProxy(new UserAddressee(mock.Object), 1);
        proxy.SendMsg(message);

        Assert.Throws<ArgumentOutOfRangeException>(() => mock.Object.GetMsgWithInfo(0));
    }
}