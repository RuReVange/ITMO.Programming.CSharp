namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.SsdDirectory;

public interface ISsdBuilder
{
    ISsdBuilder WithConnectionOption(string? connectionOption);
    ISsdBuilder WithMemorySize(int memorySize);
    ISsdBuilder WithMaxOperatingSpeed(int maxOperatingSpeed);
    ISsdBuilder WithPowerConsumption(int powerConsumption);
    void DeBuild(ISsd ssd);
    ISsd Build();
}