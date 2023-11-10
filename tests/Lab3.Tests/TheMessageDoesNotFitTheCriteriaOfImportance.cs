using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TheMessageDoesNotFitTheCriteriaOfImportance
{
    [Fact]
    public void TestMethod()
    {
        var message = new Message("header", "body", 3);

        var mock = new Mock<BaseDisplay>();
        var proxy = new AddresseeProxy(new DisplayAddressee(mock.Object));
        proxy.SendMsg(message);

        Assert.True(mock.Object.Message is null);
    }
}