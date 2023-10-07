using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public abstract class AbstractHull
{
    protected AbstractHull(int quantityAsteroid, int quantityMeteorite)
    {
        AsteroidDamage = quantityMeteorite;
        MeteoriteDamage = quantityAsteroid;
        HealthPoint = quantityAsteroid * quantityMeteorite;
        SpaceWhaleDamage = HealthPoint;
    }

    protected int SpaceWhaleDamage { get; init; }
    protected int AsteroidDamage { get; init; }
    protected int MeteoriteDamage { get; init; }
    protected int HealthPoint { get; set; }

    public bool IsAlive()
    {
        return HealthPoint > 0;
    }

    public IResult TakeDamage(AbstractObstacle? obstacle) // метод для подсчета урона
    {
        switch (obstacle)
        {
            case null:
                return new NullReference();
            case AntimatterFlares:
                return obstacle.Quantity > 0 ? new DeadShipsCrew() : new DefaultSuccess();
        }

        int damage = SetDamage(obstacle);
        int tmpQuantity = obstacle.Quantity;

        // через цикл, потому что нужно отследить момент, когда Health перейдет в 0
        for (int i = 0; i < tmpQuantity; ++i)
        {
            if (!IsAlive())
                return new ShipDestruction();
            HealthPoint -= damage;
            --obstacle.Quantity;
        }

        return new DefaultSuccess();
    }

    private int SetDamage(AbstractObstacle? obstacle)
    {
        if (obstacle is Asteroid) return AsteroidDamage;
        else if (obstacle is Meteorite) return MeteoriteDamage;
        else if (obstacle is SpaceWhale) return SpaceWhaleDamage;

        return 0;
    }
}