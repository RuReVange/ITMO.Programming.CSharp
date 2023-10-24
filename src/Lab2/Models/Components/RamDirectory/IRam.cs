using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.RamDirectory;

public interface IRam
{
    public int MemorySize { get; init; }
    public IList<RamMemoryFrequencyAndVoltage>? MemoryFrequencyList { get; init; }
    public IList<Xmp>? SupportedXmpProfileList { get; init; }
    public FormFactor? FormFactor { get; init; } // DIMM, SODIMM, SDRAM
    public string? DdrStandard { get; init; }
    public double PowerConsumption { get; init; }
}