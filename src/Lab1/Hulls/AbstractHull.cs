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

    public int SpaceWhaleDamage { get; set; }
    protected int AsteroidDamage { get; init; }
    protected int MeteoriteDamage { get; init; }
    protected int HealthPoint { get; set; }

    public bool IsAlive()
    {
        return HealthPoint > 0;
    }

    public void TakeDamage(AbstractObstacle? obstacle) // метод для подсчета урона
    {
        if (obstacle is null) return;

        int damage = SetDamage(obstacle);
        int tmpQuantity = obstacle.Quantity;

        // через цикл, потому что нужно отследить момент, когда Health перейдет в 0
        for (int i = 0; i < tmpQuantity; ++i)
        {
            HealthPoint -= damage;
            --obstacle.Quantity;
            if (!IsAlive())
                return;
        }
    }

    protected int SetDamage(AbstractObstacle? obstacle)
    {
        if (obstacle is Asteroid) return AsteroidDamage;
        else if (obstacle is Meteorite) return MeteoriteDamage;
        else if (obstacle is SpaceWhale) return SpaceWhaleDamage;

        return 0;
    }
}