namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class Videocard
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
    public int PcieVersion { get; init; }
    public int GpuFrequency { get; init; }
    public int PowerConsumption { get; init; }
}