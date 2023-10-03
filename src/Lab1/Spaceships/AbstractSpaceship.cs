using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public abstract class AbstractSpaceship
{
    public AbstractImpulseEngine? ImpulseEngine { get; init; }
    public AbstractJumpEngine? JumpEngine { get; init; }
    public AbstractDeflector? Deflector { get; init; }
    public AbstractHull? Hull { get; init; }
    public bool AntiNeutrinoEmitter { get; init; }
}