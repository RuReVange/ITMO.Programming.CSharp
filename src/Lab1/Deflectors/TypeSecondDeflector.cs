namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class TypeSecondDeflector : AbstractDeflector
{
    private const int PosssibleQtyAsteroidForDeflector = 10;
    private const int PosssibleQtyMeteoriteForDeflector = 3;
    public TypeSecondDeflector(bool photonDeflector, int quantityAsteroid = PosssibleQtyAsteroidForDeflector, int quantityMeteor = PosssibleQtyMeteoriteForDeflector)
        : base(photonDeflector, quantityAsteroid, quantityMeteor) { }
}