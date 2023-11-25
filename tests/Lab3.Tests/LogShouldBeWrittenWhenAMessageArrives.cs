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

        MockLogger mock = Substitute.For<MockLogger>();
        IAddressee addressee = new AddresseeLogger(new UserAddressee(user), mock);
        addressee.SendMsg(message);

        Assert.True(MockLogger.LogCounter == 1);
    }
}