namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class JumpEngineGamma : AbstractJumpEngine
{
    public JumpEngineGamma()
        : base()
    {
        FuelConsumption *= FuelConsumption;
        FuelTank *= 100;

        // consumption n^2
    }
}