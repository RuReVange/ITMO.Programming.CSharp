namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PowerSupplyUnitDirectory;

public interface IPowerSupplyUnit : IComponent
{
    public int PeakPower { get; init; } // в ватт
}