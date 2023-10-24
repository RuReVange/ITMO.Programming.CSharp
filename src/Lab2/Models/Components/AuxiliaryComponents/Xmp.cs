namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

public class Xmp
{
    public Xmp((int First, int Second, int Third, int Fourth) timings, double voltage, int memoryFrequency)
    {
        Timings = timings;
        Voltage = voltage;
        MemoryFrequency = memoryFrequency;
    }

    public (int First, int Second, int Third, int Fourth) Timings { get; init; }
    public double Voltage { get; init; }
    public int MemoryFrequency { get; init; }
}