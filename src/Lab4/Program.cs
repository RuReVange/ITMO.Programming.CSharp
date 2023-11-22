using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        string localPath = "C:\\Users\\Daniil\\Desktop";
        ICommand command = new ConnectCommand(localPath);
        command.Execute();
        Console.WriteLine(Directory.GetCurrentDirectory());

        // string tmp = ".\\Трассировки";
        //
        // command = new TreeGotoCommand(tmp);
        // command.Execute();
        // Console.WriteLine(Directory.GetCurrentDirectory());

        // string sourcePath = "C:\\Users\\Daniil\\Desktop\\БЭВМ\\Отчеты\\lab-4.txt";
        // string destinationPath = "C:\\Users\\Daniil\\Desktop\\БЭВМ\\Трассировки\\lab-4.txt";
        // command = new FileMoveCommand(sourcePath, destinationPath);
        // command.Execute();
        // string sourcePath = "C:\\Users\\Daniil\\Desktop\\БЭВМ\\Трассировки\\lab-4.txt";
        // string destinationPath = "C:\\Users\\Daniil\\Desktop\\БЭВМ\\Отчеты\\lab-4-1.txt";
        // command = new FileCopyCommand(sourcePath, destinationPath);
        // command.Execute();

        // command = new FileDeleteCommand(destinationPath);
        // command.Execute();

        // Console.WriteLine(Path.GetFullPath(tmp));
        // command = new DisconnectCommand();
        // command.Execute();
        // command = new TreeListCommand(2);
        // command.Execute();
    }
}