using Itmo.ObjectOrientedProgramming.Lab4.DataContext;
using Itmo.ObjectOrientedProgramming.Lab4.Parser;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class FileShowCommandTest
{
    [Fact]
    public void Method()
    {
        string parsingString = "file show C:\\Users\\Daniil\\Desktop\\БЭВМ\\Трассировки\\lab4.txt -m console";

        var commandContext = new CommandContext();
        commandContext.Parse(parsingString);

        IParser parser = new StartParser();
        parser.Parse(commandContext);

        Assert.True(Context.ResultCommandString.Equals("Vishel zayac pogulyat'"));
    }
}

// connect C:\Users\Daniil\Desktop -m local
// tree goto C:\Users\Daniil\Desktop\БЭВМ\Трассировки
// file show C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt -m console
// tree list
// tree list -d 3
// file move C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab4.txt
// file copy C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab4.txt C:\Users\Daniil\Desktop\БЭВМ\Трассировки\lab4.txt
// file rename C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab4.txt lab5.txt
// file delete C:\Users\Daniil\Desktop\БЭВМ\Отчеты\lab5.txt
// disconnect

// while (true)
// {
//     Console.WriteLine("Write the command, please");
//     string? parsingString = Console.ReadLine();
//
//     var commandContext = new CommandContext();
//     if (parsingString != null)
//         commandContext.Parse(parsingString);
//
//     IParser parser = new StartParser();
//     parser.Parse(commandContext);
// }