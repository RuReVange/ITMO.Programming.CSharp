namespace Itmo.ObjectOrientedProgramming.Lab3.Display;

public abstract class BaseDisplayDecorator : BaseDisplay
{
    protected BaseDisplayDecorator(BaseDisplay display)
    {
        Display = display;
    }

    protected BaseDisplay Display { get; set; }
}