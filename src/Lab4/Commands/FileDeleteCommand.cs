using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileDeleteCommand : ICommand
{
    private string _path;

    public FileDeleteCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (!File.Exists(_path))
        {
            Console.WriteLine("This path doesn't exist");
            return;
        }

        File.Delete(_path);
    }
}