namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class TypeThirdDeflector : AbstractDeflector
{
    public TypeThirdDeflector(bool photonDeflector, int quantityAsteroid = 40, int quantityMeteor = 10)
        : base(photonDeflector, quantityAsteroid, quantityMeteor)
    {
        SpaceWhaleDamage = HealthPoint - 1;
    }
}