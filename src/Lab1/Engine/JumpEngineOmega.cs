using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class JumpEngineOmega : AbstractJumpEngine
{
    public JumpEngineOmega()
        : base()
    {
        FuelConsumption *= (int)Math.Round(Math.Log(FuelConsumption)); // consumption nlogn
    }
}