using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeProxy : IAddressee
{
    private IAddressee? _addressee;

    public AddresseeProxy(IAddressee? addressee)
    {
        _addressee = addressee;
    }

    public void SendMsg(Message message, Func<int, int, bool>? func = null)
    {
        _addressee?.SendMsg(message, Validate);
    }

    private static bool Validate(int x, int y)
    {
        return x <= y;
    }

    private void Log(Message message)
    {
        Console.WriteLine(message.ToString() + " was sended to " + _addressee?.ToString());
    }
}