namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public class TypeThirdHull : AbstractHull
{
    private const int PosssibleQtyAsteroidForHull = 20;
    private const int PosssibleQtyMeteoriteForHull = 5;
    public TypeThirdHull(int quantityAsteroid = PosssibleQtyAsteroidForHull, int quantityMeteor = PosssibleQtyMeteoriteForHull)
        : base(quantityAsteroid, quantityMeteor) { }
}