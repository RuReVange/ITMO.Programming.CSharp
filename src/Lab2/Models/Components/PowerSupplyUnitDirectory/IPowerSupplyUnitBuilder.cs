namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PowerSupplyUnitDirectory;

public interface IPowerSupplyUnitBuilder
{
    IPowerSupplyUnitBuilder WithPeakPower(int peakPower);

    void DeBuild(IPowerSupplyUnit powerSupplyUnit);
    IPowerSupplyUnit Build();
}