namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public class Display : BaseDisplay
{
    public Display() { }
    public override void WriteMessage()
    {
        WriteMessageHeader();
        WriteMessageBody();
    }
}