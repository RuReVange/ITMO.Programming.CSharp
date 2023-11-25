using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;

public class Display
{
    private DisplayDriver _driver;
    private Message? _message;
    public Display(DisplayDriver driver)
    {
        _driver = driver;
    }

    public void AddMsg(Message message)
    {
        _message = message;
    }

    public void SendMsg()
    {
        if (_message is null) return;
        _driver.WriteMsg(_message);
        _driver.CleanDriver(_message);
    }
}