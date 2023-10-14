namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class JumpEngineGamma : AbstractJumpEngine
{
    private const int Accelerator = 100;
    public JumpEngineGamma()
        : base()
    {
        FuelConsumption *= FuelConsumption;
        FuelTank *= Accelerator;

        // consumption n^2
    }
}