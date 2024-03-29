using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.RamDirectory;

public class Ram : IRam
{
    public Ram(int memorySize, IList<RamMemoryFrequencyAndVoltage>? memoryFrequencyList, Xmp? supportedXmpProfile, FormFactor? formFactor, string? ddrStandard, double powerConsumption)
    {
        ComponentType = "Ram";
        MemorySize = memorySize;
        MemoryFrequencyList = memoryFrequencyList;
        SupportedXmpProfile = supportedXmpProfile;
        FormFactor = formFactor;
        DdrStandard = ddrStandard;
        PowerConsumption = powerConsumption;
    }

    public string ComponentType { get; init; }
    public int MemorySize { get; init; }
    public IList<RamMemoryFrequencyAndVoltage>? MemoryFrequencyList { get; init; }
    public Xmp? SupportedXmpProfile { get; init; }
    public FormFactor? FormFactor { get; init; } // DIMM, SODIMM, SDRAM
    public string? DdrStandard { get; init; }
    public double PowerConsumption { get; init; }
}