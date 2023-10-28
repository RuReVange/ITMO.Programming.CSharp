using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public class Augur : AbstractSpaceship
{
    public Augur(bool isPhotonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineAlpha();
        Deflector = new TypeThirdDeflector(isPhotonicDeflector);
        Hull = new TypeThirdHull();
        AntiNeutrinoEmitter = false;
    }
}