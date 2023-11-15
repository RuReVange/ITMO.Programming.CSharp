using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.UserDirectory;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class LogShouldBeWrittenWhenAMessageArrives
{
    [Fact]
    public void TestMethod()
    {
        var message = new Message("header", "body", 1);
        var user = new User();

        Logger mock = Substitute.For<Logger>();
        IAddressee addressee = new AddresseeLogger(new UserAddressee(user), mock);
        addressee.SendMsg(message);

        Assert.True(mock.LogCounter == 1);
    }
}