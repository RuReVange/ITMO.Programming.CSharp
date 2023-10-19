using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class Ram
{
    public Ram(int memorySize, IList<(int MemoryFrequency, double Voltage)>? memoryFrequencyList, IList<Xmp>? supportedXmpProfileList, string? formFactor, string? ddrStandard, int powerConsumption)
    {
        MemorySize = memorySize;
        MemoryFrequencyList = memoryFrequencyList;
        SupportedXmpProfileList = supportedXmpProfileList;
        FormFactor = formFactor;
        DdrStandard = ddrStandard;
        PowerConsumption = powerConsumption;
    }

    public int MemorySize { get; init; }
    public IList<(int MemoryFrequency, double Voltage)>? MemoryFrequencyList { get; init; }
    public IList<Xmp>? SupportedXmpProfileList { get; init; }
    public string? FormFactor { get; init; } // DIMM, SODIMM, SDRAM
    public string? DdrStandard { get; init; }
    public int PowerConsumption { get; init; }
}