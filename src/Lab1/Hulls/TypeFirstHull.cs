namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public class TypeFirstHull : AbstractHull
{
    private const int PosssibleQtyAsteroidForHull = 1;
    private const int PosssibleQtyMeteoriteForHull = 1;
    public TypeFirstHull(int quantityAsteroid = PosssibleQtyAsteroidForHull, int quantityMeteor = PosssibleQtyMeteoriteForHull)
        : base(quantityAsteroid, quantityMeteor) { }
}