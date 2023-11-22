using System;
using System.IO;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileShowCommand : ICommand
{
    private string _path;

    public FileShowCommand(string path)
    {
        _path = path;
        ResultString = new StringBuilder();
    }

    public StringBuilder ResultString { get; init; }

    public void Execute()
    {
        if (File.Exists(_path))
        {
            ResultString.Append(File.ReadAllText(_path));
        }
        else
        {
            throw new ArgumentException();
        }
    }
}