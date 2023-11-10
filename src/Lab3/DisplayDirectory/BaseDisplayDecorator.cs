namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public abstract class BaseDisplayDecorator : BaseDisplay
{
    protected BaseDisplayDecorator(BaseDisplay display)
    {
        Display = display;
    }

    protected BaseDisplay Display { get; set; }
}