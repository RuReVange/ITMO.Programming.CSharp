namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

public class Xmp
{
    public Xmp(string timings, double voltage, int memoryFrequency)
    {
        Timings = timings;
        Voltage = voltage;
        MemoryFrequency = memoryFrequency;
    }

    public string? Timings { get; init; }
    public double Voltage { get; init; }
    public int MemoryFrequency { get; init; }
}