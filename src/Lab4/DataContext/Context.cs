using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Parser;

namespace Itmo.ObjectOrientedProgramming.Lab4.DataContext;

public static class Context
{
    public static Dictionary<string, IParser> FirstLevelDictionary { get; private set; }
        = new Dictionary<string, IParser>()
    {
        { "connect", new ConnectParser() },
        { "disconnect", new DisconnectParser() },
        { "tree goto", new TreeGotoParser() },
        { "tree list", new TreeListParser() },
        { "file show", new FileShowParser() },
        { "file move", new FileMoveParser() },
        { "file copy", new FileCopyParser() },
        { "file delete", new FileDeleteParser() },
        { "file rename", new FileRenameParser() },
    };

    public static Dictionary<string, IParser> ConnectCommandFlagsDictionary { get; private set; } =
        new Dictionary<string, IParser>() { { "-m", new ConnectModeParser() } };

    public static Dictionary<string, IParser> ConnectCommandModesDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "local", new ConnectLocalModeParser() } };

    public static Dictionary<string, IParser> TreeListCommandFlagsDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "-d", new TreeListDepthParser() } };

    public static Dictionary<string, IParser> FileShowCommandFlagsDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "-m", new FileShowModeParser() } };

    public static Dictionary<string, IParser> FileShowCommandModesDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "console", new FileShowConsoleModeParser() } };

    public static void AddFirstLevelDictionary(string name, IParser parser)
    {
        FirstLevelDictionary.Add(name, parser);
    }
}