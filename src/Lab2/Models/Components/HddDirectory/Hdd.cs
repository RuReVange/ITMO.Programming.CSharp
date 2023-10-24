namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.HddDirectory;

public class Hdd : IHdd
{
    public Hdd(int memorySize, int spindleRotationSpeed, int powerConsumption)
    {
        MemorySize = memorySize;
        SpindleRotationSpeed = spindleRotationSpeed;
        PowerConsumption = powerConsumption;
    }

    public int MemorySize { get; init; } // Гб
    public int SpindleRotationSpeed { get; init; } // об/мин
    public int PowerConsumption { get; init; } // в ватт
}