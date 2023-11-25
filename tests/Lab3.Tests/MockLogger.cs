using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MockLogger : ILogger
{
    public static int LogCounter { get; private set; }

    public void Log(Message message, IAddressee addressee)
    {
        LogCounter++;
        Console.WriteLine(message?.ToString() + " was sended to " + addressee?.ToString());
    }
}