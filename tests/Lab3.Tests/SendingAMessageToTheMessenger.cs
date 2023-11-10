using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class SendingAMessageToTheMessenger
{
    [Fact]
    public void TestMethod()
    {
        var message = new Message("header", "body", 1);

        var mock = new Mock<Messenger>();
        var proxy = new AddresseeProxy(new MessengerAddressee(mock.Object));
        proxy.SendMsg(message);

        string? tmp;
        mock.Object.ShowMessage(0);
        mock.Object.MessengerBuffer(out tmp);
        Assert.True(tmp == "Messenger: " + "body");
    }
}