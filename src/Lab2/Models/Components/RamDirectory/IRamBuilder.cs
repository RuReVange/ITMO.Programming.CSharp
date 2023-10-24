using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.RamDirectory;

public interface IRamBuilder
{
    IRamBuilder WithMemorySize(int memorySize);
    IRamBuilder WithMemoryFrequencyList(IList<RamMemoryFrequencyAndVoltage> memoryFrequencyList);
    IRamBuilder WithSupportedXmpProfileList(IList<Xmp> supportedXmpProfileList);
    IRamBuilder WithFormFactor(FormFactor? formFactor);
    IRamBuilder WithDdrStandard(string? ddrStandard);
    IRamBuilder WithPowerConsumption(double powerConsumption);

    void DeBuild(IRam ram);
    IRam Build();
}