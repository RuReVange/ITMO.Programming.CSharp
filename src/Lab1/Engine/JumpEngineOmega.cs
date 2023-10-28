using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class JumpEngineOmega : AbstractJumpEngine
{
    private const int Accelerator = 10;
    public JumpEngineOmega()
        : base()
    {
        FuelConsumption *= (int)Math.Round(Math.Log(FuelConsumption));
        FuelTank *= Accelerator;

        // consumption nlogn
    }
}