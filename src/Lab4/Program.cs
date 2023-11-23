using System;

// using System.Collections.Generic;
// using System.IO;
// using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;
using Itmo.ObjectOrientedProgramming.Lab4.Parser;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        // string localPath = "C:\\Users\\Daniil\\Desktop";
        // ICommand command = new ConnectCommand(localPath);
        // command.Execute();
        // Console.WriteLine(Directory.GetCurrentDirectory());

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
        // string testString = "file show C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt -m console";
        //
        // var commandContext = new CommandContext();
        // commandContext.Parse(testString);
        // Console.WriteLine(commandContext.CommandNameAndAtributes);
        // if (commandContext.FlagDictionary != null)
        // {
        //     foreach (KeyValuePair<string, string> item in commandContext.FlagDictionary)
        //     {
        //         Console.WriteLine($"{item.Key} -> {item.Value}");
        //     }
        // }
        // connect C:\Users\Daniil\Desktop -m local
        // tree goto C:\Users\Daniil\Desktop\БЭВМ
        // file show C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt -m console
        // tree list
        // tree list -d 3
        // file move C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab4.txt
        // file copy C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab4.txt C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt
        // file rename C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab4.txt lab5.txt
        // file delete C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab5.txt
        // disconnect
        while (true)
        {
            Console.WriteLine("Write the command, please");
            string? parsingString = Console.ReadLine();

            var commandContext = new CommandContext();
            if (parsingString != null)
                commandContext.Parse(parsingString);

            IParser parser = new StartParser();
            parser.Parse(commandContext);
        }
    }
}