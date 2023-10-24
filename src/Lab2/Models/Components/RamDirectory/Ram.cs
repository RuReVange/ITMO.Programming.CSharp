using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.RamDirectory;

public class Ram : IRam
{
    public Ram(int memorySize, IList<RamMemoryFrequencyAndVoltage>? memoryFrequencyList, IList<Xmp>? supportedXmpProfileList, FormFactor? formFactor, string? ddrStandard, double powerConsumption)
    {
        MemorySize = memorySize;
        MemoryFrequencyList = memoryFrequencyList;
        SupportedXmpProfileList = supportedXmpProfileList;
        FormFactor = formFactor;
        DdrStandard = ddrStandard;
        PowerConsumption = powerConsumption;
    }

    public int MemorySize { get; init; }
    public IList<RamMemoryFrequencyAndVoltage>? MemoryFrequencyList { get; init; }
    public IList<Xmp>? SupportedXmpProfileList { get; init; }
    public FormFactor? FormFactor { get; init; } // DIMM, SODIMM, SDRAM
    public string? DdrStandard { get; init; }
    public double PowerConsumption { get; init; }
}