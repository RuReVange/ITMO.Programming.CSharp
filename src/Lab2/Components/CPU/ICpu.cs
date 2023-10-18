namespace Itmo.ObjectOrientedProgramming.Lab2.Components.CPU;

public interface ICpu
{
    public int CoreFrequency { get; init; }
    public int CoreQty { get; init; }
    public string Socket { get; init; }
    public bool VideoCore { get; init; }
    public int SupportedMemoryFrequency { get; init; }
    public int Tdp { get; init; }
    public int PowerConsumption { get; init; }
}