namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class TypeSecondDeflector : AbstractDeflector
{
    public TypeSecondDeflector(bool photonDeflector, int quantityAsteroid = 10, int quantityMeteor = 3)
        : base(photonDeflector, quantityAsteroid, quantityMeteor) { }
}