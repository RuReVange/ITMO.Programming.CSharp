namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class PowerSupplyUnit
{
    public PowerSupplyUnit(int peakPower)
    {
        PeakPower = peakPower;
    }

    public int PeakPower { get; init; }
}