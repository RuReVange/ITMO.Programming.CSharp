using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class Logger : ILogger
{
    public void Log(Message message, IAddressee addressee)
    {
        Console.WriteLine(message?.ToString() + " was sended to " + addressee?.ToString());
    }
}