using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public class Meridian : AbstractSpaceship
{
    public Meridian(bool isPhotonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineE();
        Deflector = new TypeSecondDeflector(isPhotonicDeflector);
        Hull = new TypeSecondHull();
        AntiNeutrinoEmitter = true;
    }
}