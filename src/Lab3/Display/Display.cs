using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display;

public class Display : BaseDisplay
{
    public Display(Message message)
    {
        Message = message;
    }

    public override void WriteMessage()
    {
        WriteMessageHeader();
        WriteMessageBody();
    }
}