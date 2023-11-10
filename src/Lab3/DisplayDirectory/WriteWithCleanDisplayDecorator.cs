namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public class WriteWithCleanDisplayDecorator : BaseDisplayDecorator
{
    public WriteWithCleanDisplayDecorator(BaseDisplay display)
        : base(display) { }

    public override void WriteMessage()
    {
        Display.WriteMessage();
        Display.Message = null;
    }
}