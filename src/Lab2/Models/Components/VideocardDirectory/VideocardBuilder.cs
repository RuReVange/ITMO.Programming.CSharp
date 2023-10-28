using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.VideocardDirectory;

public class VideocardBuilder : IVideocardBuilder
{
    private FormFactor? _formFactor;
    private int _videoCardMemorySize;
    private int _pcieVersion;
    private int _gpuFrequency;
    private int _powerConsumption;

    public IVideocardBuilder WithFormFactor(FormFactor? formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IVideocardBuilder WithVideoCardMemorySize(int videoCardMemorySize)
    {
        _videoCardMemorySize = videoCardMemorySize;
        return this;
    }

    public IVideocardBuilder WithPcieVersion(int pcieVersion)
    {
        _pcieVersion = pcieVersion;
        return this;
    }

    public IVideocardBuilder WithGpuFrequency(int gpuFrequency)
    {
        _gpuFrequency = gpuFrequency;
        return this;
    }

    public IVideocardBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public void DeBuild(IVideocard videocard)
    {
        _formFactor = videocard.FormFactor;
        _videoCardMemorySize = videocard.VideoCardMemorySize;
        _pcieVersion = videocard.PcieVersion;
        _gpuFrequency = videocard.GpuFrequency;
        _powerConsumption = videocard.PowerConsumption;
    }

    public IVideocard Build()
    {
        return new Videocard(
            _formFactor,
            _videoCardMemorySize,
            _pcieVersion,
            _gpuFrequency,
            _powerConsumption);
    }
}