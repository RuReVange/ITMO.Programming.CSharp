namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public abstract class AbstractJumpEngine : AbstractEngine
{
    private const int StandardSpeed = 50;
    private const int StandardConsumption = 20;
    private const int StandardFuelTank = 500;
    protected AbstractJumpEngine()
    {
        Speed = StandardSpeed;
        FuelConsumption = StandardConsumption;
        FuelTank = StandardFuelTank;
    }
}