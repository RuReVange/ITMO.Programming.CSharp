using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileShowCommand : ICommand
{
    private string _path;

    public FileShowCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (File.Exists(_path))
        {
            Context.ResultCommandString.Clear();
            Context.ResultCommandString.Append(File.ReadAllText(_path));
        }
        else
        {
            throw new ArgumentException();
        }
    }
}