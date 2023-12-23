namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.SsdDirectory;

public interface ISsd
{
    public string? ConnectionOption { get; init; } // PCI-E / Sata
    public int MemorySize { get; init; } // Гб
    public int MaxOperatingSpeed { get; init; } // МБ/с
    public int PowerConsumption { get; init; } // в ватт
}