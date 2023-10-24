namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PowerSupplyUnitDirectory;

public class PowerSupplyUnit : IPowerSupplyUnit
{
    public PowerSupplyUnit(int peakPower)
    {
        PeakPower = peakPower;
    }

    public int PeakPower { get; init; } // в ватт
}