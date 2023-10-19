using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class Bios
{
    public Bios(int type, int version, IList<string>? supportedProcessorsList)
    {
        Type = type;
        Version = version;
        SupportedProcessorsList = supportedProcessorsList;
    }

    public int Type { get; init; }
    public int Version { get; init; }
    public IList<string>? SupportedProcessorsList { get; init; }
}