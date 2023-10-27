namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.HddDirectory;

public interface IHdd : IComponent
{
    public int MemorySize { get; init; } // Гб
    public int SpindleRotationSpeed { get; init; } // об/мин
    public int PowerConsumption { get; init; } // в ватт
}