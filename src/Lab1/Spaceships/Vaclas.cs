using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public class Vaclas : AbstractSpaceship
{
    public Vaclas(bool isPhotonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineGamma();
        Deflector = new TypeFirstDeflector(isPhotonicDeflector);
        Hull = new TypeSecondHull();
        AntiNeutrinoEmitter = false;
    }
}