using Itmo.ObjectOrientedProgramming.Lab3.DisplayDirectory;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class DisplayAddressee : IAddressee
{
    private Display _display;

    public DisplayAddressee(Display display)
    {
        _display = display;
    }

    public void SendMsg(Message message)
    {
        _display.AddMsg(message);
    }
}