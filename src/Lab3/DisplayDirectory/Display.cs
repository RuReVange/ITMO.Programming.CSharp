using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public class Display
{
    public Display(DisplayDriver driver)
    {
        Driver = driver;
    }

    public DisplayDriver Driver { get; init; }
    protected internal Message? Message { get; set; }
    public void AddMsg(Message message)
    {
        Message = message;
    }
}