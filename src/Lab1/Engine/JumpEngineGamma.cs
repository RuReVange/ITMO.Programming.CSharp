namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class JumpEngineGamma : AbstractJumpEngine
{
    public JumpEngineGamma()
        : base()
    {
        FuelConsumption *= FuelConsumption;

        // consumption n^2
    }
}