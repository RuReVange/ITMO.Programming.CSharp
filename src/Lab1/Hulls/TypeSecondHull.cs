namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public class TypeSecondHull : AbstractHull
{
    private const int PosssibleQtyAsteroidForHull = 5;
    private const int PosssibleQtyMeteoriteForHull = 2;
    public TypeSecondHull(int quantityAsteroid = PosssibleQtyAsteroidForHull, int quantityMeteor = PosssibleQtyMeteoriteForHull)
        : base(quantityAsteroid, quantityMeteor) { }
}