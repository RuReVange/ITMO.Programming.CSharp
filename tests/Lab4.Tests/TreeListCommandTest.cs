using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;
using Itmo.ObjectOrientedProgramming.Lab4.Parser;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class TreeListCommandTest
{
    [Fact]
    public void Method()
    {
        string parsingString = "connect C:\\Users\\Daniil\\Desktop\\БЭВМ\\Трассировки -m local";
        var commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);

        IParser parser = new StartParser();
        parser.Parse(commandContext);

        Assert.True(commandContext.Command is ConnectCommand);

        parsingString = "tree list";
        commandContext = new CommandContext();
        CommandParser.Parse(commandContext, parsingString);
        parser.Parse(commandContext);

        Assert.True(commandContext.Command is TreeListCommand);
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
// file: lab4.txt
// file: tracing.html
// file: tracingLaba1.html
