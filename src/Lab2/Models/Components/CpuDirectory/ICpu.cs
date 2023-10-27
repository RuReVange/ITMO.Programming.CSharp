using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuDirectory;

public interface ICpu
{
    public float CoreFrequency { get; init; }
    public int CoreQty { get; init; }
    public string? Socket { get; init; }
    public bool VideoCore { get; init; }
    public IList<int> SupportedMemoryFrequencyList { get; init; } // МГц
    public int Tdp { get; init; }
    public int PowerConsumption { get; init; }
}