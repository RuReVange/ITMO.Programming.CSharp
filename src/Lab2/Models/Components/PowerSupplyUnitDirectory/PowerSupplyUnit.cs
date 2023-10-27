namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PowerSupplyUnitDirectory;

public class PowerSupplyUnit : IPowerSupplyUnit
{
    public PowerSupplyUnit(int peakPower)
    {
        ComponentType = "PowerSupplyUnit";
        PeakPower = peakPower;
    }

    public string ComponentType { get; init; }
    public int PeakPower { get; init; } // в ватт
}