using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class LogShouldBeWrittenWhenAMessageArrives
{
    [Fact]
    public void TestMethod()
    {
        var message = new Message("header", "body", 1);

        var mock = new Mock<User>();
        var proxy = new AddresseeProxy(new UserAddressee(mock.Object));
        proxy.SendMsg(message);

        int value;
        proxy.ReceiveLogCounter(out value);

        Assert.True(value == 1);
    }
}