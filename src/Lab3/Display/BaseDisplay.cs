using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display;

public abstract class BaseDisplay
{
    protected internal Message? Message { get; set; }

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