using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeProxy : IAddressee
{
    private readonly int _zeroImportanceLevel;
    private IAddressee? _addressee;

    public AddresseeProxy(IAddressee? addressee)
    {
        _addressee = addressee;
        _zeroImportanceLevel = 0;
    }

    public int GetThisPossibleImportanceLevel()
    {
        return _addressee != null ? _addressee.GetThisPossibleImportanceLevel() : _zeroImportanceLevel;
    }

    public void SendMsg(Message message)
    {
        if (message != null && _addressee != null && Validate(message.ImportanceLevel, GetThisPossibleImportanceLevel()))
        {
            _addressee.SendMsg(message);
            Log(message);
        }
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