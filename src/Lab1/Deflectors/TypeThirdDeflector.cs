namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class TypeThirdDeflector : AbstractDeflector
{
    private const int PosssibleQtyAsteroidForDeflector = 40;
    private const int PosssibleQtyMeteoriteForDeflector = 10;
    public TypeThirdDeflector(bool photonDeflector, int quantityAsteroid = PosssibleQtyAsteroidForDeflector, int quantityMeteor = PosssibleQtyMeteoriteForDeflector)
        : base(photonDeflector, quantityAsteroid, quantityMeteor)
    {
        SpaceWhaleDamage = HealthPoint - 1;
    }
}