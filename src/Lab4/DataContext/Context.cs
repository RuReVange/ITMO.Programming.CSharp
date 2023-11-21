using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.DataContext;

public static class Context
{
    public static string? Path { get; internal set; } = Directory.GetCurrentDirectory();
}