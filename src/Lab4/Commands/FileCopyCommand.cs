using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileCopyCommand : ICommand
{
    private string _sourcePath;
    private string _destinationPath;

    public FileCopyCommand(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute()
    {
        if (!File.Exists(_sourcePath) || !File.Exists(_destinationPath))
        {
            Console.WriteLine("This path doesn't exist");
            return;
        }

        File.Copy(_sourcePath, _destinationPath, true);
    }
}