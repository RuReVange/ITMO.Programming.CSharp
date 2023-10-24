namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.SsdDirectory;

public class Ssd : ISsd
{
    public Ssd(string? connectionOption, int memorySize, int maxOperatingSpeed, int powerConsumption)
    {
        ConnectionOption = connectionOption;
        MemorySize = memorySize;
        MaxOperatingSpeed = maxOperatingSpeed;
        PowerConsumption = powerConsumption;
    }

    public string? ConnectionOption { get; init; } // PCI-E / Sata
    public int MemorySize { get; init; } // Гб
    public int MaxOperatingSpeed { get; init; } // МБ/с
    public int PowerConsumption { get; init; } // в ватт
}