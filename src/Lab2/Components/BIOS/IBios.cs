using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components.BIOS;

public interface IBios
{
    public int Type { get; init; }
    public int Version { get; init; }
    public IList<string> SupportedProcessorsList { get; init; }
}