using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Modifiers;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public class DisplayDriver
{
    private Color _color = new Color(255, 255, 255);

    #pragma warning disable CA1822
    public Message? CleanDriver(Message? message)
    {
        return message == null ? message : null;
    }
    #pragma warning restore CA1822

    public void ChangeColor(Color? color)
    {
        _color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public Message ColorizeDriver(Message message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));
        var tmp = new Message(ColorModifier.Modify(message.Header, _color), ColorModifier.Modify(message.Body, _color), message.ImportanceLevel);
        return tmp;
    }

    public void WriteMsg(Message message)
    {
        Console.WriteLine(ColorizeDriver(message).Header);
        Console.WriteLine(ColorizeDriver(message).Body);
    }
}