namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public abstract class AbstractDeflector
{
    protected AbstractDeflector(int quantityAsteroid, int quantityMeteorite)
    {
        AsteroidDamage = quantityMeteorite;
        MeteoriteDamage = quantityAsteroid;
        HealthPoint = quantityAsteroid * quantityMeteorite;
        SpaceWhaleDamage = HealthPoint;
    }

    protected int AsteroidDamage { get; init; }
    protected int MeteoriteDamage { get; init; }
    protected int SpaceWhaleDamage { get; init; }
    protected int HealthPoint { get; set; }

    public bool IsAlive()
    {
        if (HealthPoint > 0) return true;
        return false;
    }

    public void Destruction(AbstractObstacle obstacle) // метод для подсчета урона
    {
        if (obstacle != null)
        {
            int tmpQuantity = obstacle.Quantity;
            if (obstacle is Asteroid)
            {
                // через цикл, потому что нужно отследить момент, когда Health перейдет в 0
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

    // public void Destruction(class Obstacle){}
    //
    // В классе препятствие храним колличество препятствий
    // 1 класс на все препятствия
    // использовать pattern matching (с проверкой на is)
    // if (obstacle is meteorite)
}