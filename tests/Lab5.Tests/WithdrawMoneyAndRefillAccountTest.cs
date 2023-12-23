using ApplicationCore.Models.DomainModels;
using NSubstitute;
using ParserInfrastructure.Parser;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class WithdrawMoneyAndRefillAccountTest
{
    [Fact]
    public void TestMethod()
    {
        string parsingString = "withdraw money -b 100";

        var commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);

        IParser mock = Substitute.For<StartParser>();
        mock.Parse(commandContext);

        Assert.True(commandContext.ResultValue == -1);

        parsingString = "login -m admin -p password";
        commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);
        mock.Parse(commandContext);

        parsingString = "add regular user -p zayac1";
        commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);
        mock.Parse(commandContext);

        parsingString = "login -m user -i 1 -p zayac1";
        commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);
        mock.Parse(commandContext);

        parsingString = "refill account -b 250";
        commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);

        mock.Parse(commandContext);

        Assert.True(commandContext.ResultValue == 250);
    }
}