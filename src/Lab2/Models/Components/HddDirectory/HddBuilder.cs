namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.HddDirectory;

public class HddBuilder : IHddBuilder
{
    private int _memorySize;
    private int _spindleRotationSpeed;
    private int _powerConsumption;

    public IHddBuilder WithMemorySize(int memorySize)
    {
        _memorySize = memorySize;
        return this;
    }

    public IHddBuilder WithSpindleRotationSpeed(int spindleRotationSpeed)
    {
        _spindleRotationSpeed = spindleRotationSpeed;
        return this;
    }

    public IHddBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public void DeBuild(IHdd hdd)
    {
        _memorySize = hdd.MemorySize;
        _spindleRotationSpeed = hdd.SpindleRotationSpeed;
        _powerConsumption = hdd.PowerConsumption;
    }

    public IHdd Build()
    {
        return new Hdd(_memorySize, _spindleRotationSpeed, _powerConsumption);
    }
}