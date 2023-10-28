using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuCoolerDirectory;

public interface ICpuCoolerBuilder
{
    ICpuCoolerBuilder WithSupportedSocketsList(IList<string> supportedSocketsList);

    ICpuCoolerBuilder WithMaxTdp(int maxTdp);

    ICpuCoolerBuilder WithFormFactor(FormFactor? formFactor);

    void DeBuild(ICpuCooler cpuCooler);

    ICpuCooler Build();
}