namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.HddDirectory;

public interface IHddBuilder
{
    IHddBuilder WithMemorySize(int memorySize);

    IHddBuilder WithSpindleRotationSpeed(int spindleRotationSpeed);

    IHddBuilder WithPowerConsumption(int powerConsumption);

    void DeBuild(IHdd hdd);
    IHdd Build();
}