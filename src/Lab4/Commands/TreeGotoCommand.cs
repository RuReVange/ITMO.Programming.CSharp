using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class TreeGotoCommand : ICommand
{
    private string _path;

    public TreeGotoCommand(string path)
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