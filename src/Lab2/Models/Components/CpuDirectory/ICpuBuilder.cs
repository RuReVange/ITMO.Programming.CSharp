using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuDirectory;

public interface ICpuBuilder
{
    ICpuBuilder WithCoreFrequency(float coreFrequency);

    ICpuBuilder WithCoreQty(int coreQty);

    ICpuBuilder WithSocket(string? socket);

    ICpuBuilder WithVideoCore(bool videoCore);

    ICpuBuilder WithSupportedMemoryFrequency(IList<int> supportedMemoryFrequencyList);

    ICpuBuilder WithTdp(int tdp);

    ICpuBuilder WithPowerConsumption(int powerConsumption);

    void DeBuild(ICpu cpu);

    ICpu Build();
}