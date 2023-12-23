using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class DisconnectCommand : ICommand
{
    public void Execute()
    {
        Directory.SetCurrentDirectory(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()));
        System.Environment.Exit(0);
    }
}