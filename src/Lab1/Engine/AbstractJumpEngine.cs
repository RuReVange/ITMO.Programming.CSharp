namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public abstract class AbstractJumpEngine : AbstractEngine
{
    protected AbstractJumpEngine()
    {
        Speed = 50;
        FuelConsumption = 20;
        FuelTank = 500;
    }
}