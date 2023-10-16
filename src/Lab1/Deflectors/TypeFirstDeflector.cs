namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class TypeFirstDeflector : AbstractDeflector
{
    private const int PosssibleQtyAsteroidForDeflector = 2;
    private const int PosssibleQtyMeteoriteForDeflector = 1;
    public TypeFirstDeflector(bool photonDeflector, int quantityAsteroid = PosssibleQtyAsteroidForDeflector, int quantityMeteor = PosssibleQtyMeteoriteForDeflector)
        : base(photonDeflector, quantityAsteroid, quantityMeteor) { }
}