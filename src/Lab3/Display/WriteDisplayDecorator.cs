namespace Itmo.ObjectOrientedProgramming.Lab3.Display;

public class WriteDisplayDecorator : BaseDisplayDecorator
{
    public WriteDisplayDecorator(BaseDisplay display)
        : base(display) { }

    public override void WriteMessage()
    {
        Display.WriteMessage();
    }
}