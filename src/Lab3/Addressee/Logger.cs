using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class Logger : IAddressee, ILogger
{
    private IAddressee? _addressee;

    public Logger(IAddressee? addressee)
    {
        _addressee = addressee;
    }

    public void SendMsg(Message message)
    {
        Log(message);
        _addressee?.SendMsg(message);
    }

    public void Log(Message message)
    {
        Console.WriteLine(message?.ToString() + " was sended to " + _addressee?.ToString());
    }
}