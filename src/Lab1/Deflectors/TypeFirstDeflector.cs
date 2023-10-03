namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class TypeFirstDeflector : AbstractDeflector
{
    public TypeFirstDeflector(bool photonDeflector, int quantityAsteroid = 2, int quantityMeteor = 1)
        : base(photonDeflector, quantityAsteroid, quantityMeteor) { }
}