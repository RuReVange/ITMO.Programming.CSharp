namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PowerSupplyUnitDirectory;

public class PowerSupplyUnitBuilder : IPowerSupplyUnitBuilder
{
    private int _peakPower;

    public IPowerSupplyUnitBuilder WithPeakPower(int peakPower)
    {
        _peakPower = peakPower;
        return this;
    }

    public void DeBuild(IPowerSupplyUnit powerSupplyUnit)
    {
        _peakPower = powerSupplyUnit.PeakPower;
    }

    public IPowerSupplyUnit Build()
    {
        return new PowerSupplyUnit(_peakPower);
    }
}