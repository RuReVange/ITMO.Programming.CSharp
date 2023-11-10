using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeProxy : IAddressee
{
    private readonly int _zeroImportanceLevel;
    private int _logCounter;
    private IAddressee? _addressee;

    public AddresseeProxy(IAddressee? addressee)
    {
        _addressee = addressee;
        _zeroImportanceLevel = 0;
        _logCounter = 0;
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

    public void Log(Message message)
    {
        Console.WriteLine(message?.ToString() + " was sended to " + _addressee?.ToString());
        _logCounter += 1;
    }

    public void ReceiveLogCounter(out int value)
    {
         value = _logCounter;
    }

    private static bool Validate(int x, int y)
    {
        return x <= y;
    }
}