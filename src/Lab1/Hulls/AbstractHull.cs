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
        if (HealthPoint > 0) return true;
        return false;
    }

    public void Destruction(AbstractObstacle obstacle)
    {
        if (obstacle != null)
        {
            int tmpQuantity = obstacle.Quantity;
            if (obstacle is Asteroid)
            {
                for (int i = 0; i < tmpQuantity; ++i)
                {
                    HealthPoint -= AsteroidDamage;
                    --obstacle.Quantity;
                    if (!IsAlive())
                        return;
                }
            }
            else if (obstacle is Meteorite)
            {
                for (int i = 0; i < tmpQuantity; ++i)
                {
                    HealthPoint -= MeteoriteDamage;
                    --obstacle.Quantity;
                    if (!IsAlive())
                        return;
                }
            }
            else if (obstacle is SpaceWhale)
            {
                for (int i = 0; i < tmpQuantity; ++i)
                {
                    HealthPoint -= SpaceWhaleDamage;
                    --obstacle.Quantity;
                    if (!IsAlive())
                        return;
                }
            }
        }
    }
}