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

    public static bool Validate(int x, int y)
    {
        return x <= y;
    }

    public void SendMsg(Message message, Func<int, int, bool>? func = default)
    {
        _addressee?.SendMsg(message, Validate);
    }
}