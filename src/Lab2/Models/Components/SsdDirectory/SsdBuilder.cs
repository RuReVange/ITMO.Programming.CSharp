namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.SsdDirectory;

public class SsdBuilder : ISsdBuilder
{
    private string? _connectionOption;
    private int _memorySize;
    private int _maxOperatingSpeed;
    private int _powerConsumption;

    public ISsdBuilder WithConnectionOption(string? connectionOption)
    {
        _connectionOption = connectionOption;
        return this;
    }

    public ISsdBuilder WithMemorySize(int memorySize)
    {
        _memorySize = memorySize;
        return this;
    }

    public ISsdBuilder WithMaxOperatingSpeed(int maxOperatingSpeed)
    {
        _maxOperatingSpeed = maxOperatingSpeed;
        return this;
    }

    public ISsdBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public void DeBuild(ISsd ssd)
    {
        _connectionOption = ssd.ConnectionOption;
        _memorySize = ssd.MemorySize;
        _maxOperatingSpeed = ssd.MaxOperatingSpeed;
        _powerConsumption = ssd.PowerConsumption;
    }

    public ISsd Build()
    {
        return new Ssd(
            _connectionOption,
            _memorySize,
            _maxOperatingSpeed,
            _powerConsumption);
    }
}