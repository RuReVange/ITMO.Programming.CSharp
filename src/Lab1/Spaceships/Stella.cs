using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public class Stella : AbstractSpaceship
{
    public Stella(bool isPhotonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineC();
        JumpEngine = new JumpEngineOmega();
        Deflector = new TypeFirstDeflector(isPhotonicDeflector);
        Hull = new TypeFirstHull();
        AntiNeutrinoEmitter = false;
    }
}