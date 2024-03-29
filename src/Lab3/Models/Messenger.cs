using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public class Messenger
{
    private string? _buffer;
    private IList<Message> _messages = new List<Message>();

    public void AddMsg(Message message)
    {
        _messages.Add(message);
    }

    public void MessengerBuffer(out string? value)
    {
        value = _buffer;
    }

    public void ShowMessage(int index)
    {
        if (index < 0 || index >= _messages.Count)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }
        else
        {
            Console.WriteLine("Messenger: " + _messages[index].Body);
            _buffer = "Messenger: " + _messages[index].Body;
        }
    }
}