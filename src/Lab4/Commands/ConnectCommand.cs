using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class ConnectCommand : ICommand
{
    private string _path;

    public ConnectCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (!Directory.Exists(_path))
        {
            Console.WriteLine("This directory doesn't exist");
            return;
        }

        Directory.SetCurrentDirectory(_path);
    }
}