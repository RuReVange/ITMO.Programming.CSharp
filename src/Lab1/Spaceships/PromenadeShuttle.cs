using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public class PromenadeShuttle : AbstractSpaceship
{
    public PromenadeShuttle()
    {
        ImpulseEngine = new ImpulseEngineC();
        JumpEngine = null;
        Deflector = null;
        Hull = new TypeFirstHull();
        AntiNeutrinoEmitter = false;
    }
}