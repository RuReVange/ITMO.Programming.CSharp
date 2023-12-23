using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.VideocardDirectory;

public interface IVideocardBuilder
{
    IVideocardBuilder WithFormFactor(FormFactor? formFactor);
    IVideocardBuilder WithVideoCardMemorySize(int videoCardMemorySize);
    IVideocardBuilder WithPcieVersion(int pcieVersion);
    IVideocardBuilder WithGpuFrequency(int gpuFrequency);
    IVideocardBuilder WithPowerConsumption(int powerConsumption);
    void DeBuild(IVideocard videocard);
    IVideocard Build();
}