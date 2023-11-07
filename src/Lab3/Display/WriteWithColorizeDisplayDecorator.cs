using System;
using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Modifiers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display;

public class WriteWithColorizeDisplayDecorator : BaseDisplayDecorator
{
    private readonly ColorModifier _colorModifier;
    private string _buffer = " ";

    public WriteWithColorizeDisplayDecorator(BaseDisplay display, Color color)
        : base(display)
    {
        _colorModifier = new ColorModifier(color);
        if (Display.Message != null)
        {
            _buffer = Display.Message.Body;
        }
        else
        {
            Console.WriteLine("Display.Message is null");
        }
    }

    public override void WriteMessage()
    {
        Display.WriteMessageHeader();
        Console.WriteLine(_colorModifier.Modify(_buffer));
    }
}