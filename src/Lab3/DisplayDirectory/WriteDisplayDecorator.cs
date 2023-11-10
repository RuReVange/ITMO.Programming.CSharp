namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public class WriteDisplayDecorator : BaseDisplayDecorator
{
    public WriteDisplayDecorator(BaseDisplay display)
        : base(display) { }

    public override void WriteMessage()
    {
        Display.WriteMessage();
    }
}