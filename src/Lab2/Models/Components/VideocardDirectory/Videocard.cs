using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.VideocardDirectory;

public class Videocard : IVideocard
{
    public Videocard(FormFactor? formFactor, int videoCardMemorySize, int pcieVersion, int gpuFrequency, int powerConsumption)
    {
        FormFactor = formFactor;
        VideoCardMemorySize = videoCardMemorySize;
        PcieVersion = pcieVersion;
        GpuFrequency = gpuFrequency;
        PowerConsumption = powerConsumption;
    }

    public FormFactor? FormFactor { get; init; }
    public int VideoCardMemorySize { get; init; }
    public int PcieVersion { get; init; } // 1.0, 2.0, 3.0 и 4.0
    public int GpuFrequency { get; init; }
    public int PowerConsumption { get; init; }
}