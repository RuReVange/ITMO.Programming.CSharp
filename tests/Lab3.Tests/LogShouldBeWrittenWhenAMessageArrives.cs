using System.Collections;
using System.Linq;
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

        ILogger mock = Substitute.For<ILogger>();
        mock.Log(message);

        IEnumerable enumerable = mock.ReceivedCalls();

        Assert.Single(mock.ReceivedCalls().Where(call => call.GetMethodInfo().Name == "Log"));
    }
}