using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public abstract class BaseDisplay
{
    protected internal Message? Message { get; set; }

    public void AddMsg(Message message)
    {
        Message = message;
    }

    public void WriteMessageHeader()
    {
        Console.WriteLine(Message?.Header);
    }

    public void WriteMessageBody()
    {
        Console.WriteLine(Message?.Body);
    }

    public abstract void WriteMessage();
}