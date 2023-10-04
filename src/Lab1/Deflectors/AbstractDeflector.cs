using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public abstract class AbstractDeflector
{
    protected AbstractDeflector(bool photonDeflector, int quantityAsteroid, int quantityMeteorite)
    {
        AsteroidDamage = quantityMeteorite;
        MeteoriteDamage = quantityAsteroid;
        HealthPoint = quantityAsteroid * quantityMeteorite;
        SpaceWhaleDamage = HealthPoint;
        PhotonDeflector = photonDeflector ? new PhotonicDeflector() : null;
    }

    internal PhotonicDeflector? PhotonDeflector { get; init; }
    protected int AsteroidDamage { get; init; }
    protected int MeteoriteDamage { get; init; }
    protected int SpaceWhaleDamage { get; init; }
    protected int HealthPoint { get; set; }

    public bool IsAlive()
    {
        return HealthPoint > 0;
    }

    public IResult TakeDamage(AbstractObstacle? obstacle) // метод для подсчета урона
    {
        if (obstacle is null) return new NullReference();

        if (obstacle is AntimatterFlares flares)
        {
            // #pragma warning disable SK1200
            return PhotonDeflector is not null ? PhotonDeflector.TakeDamage(flares) : new DeadShipsCrew();

            // #pragma restore disable SK1200
        }
        else
        {
            int damage = SetDamage(obstacle);
            int tmpQuantity = obstacle.Quantity;

            // через цикл, потому что нужно отследить момент, когда Health перейдет в 0
            for (int i = 0; i < tmpQuantity; ++i)
            {
                HealthPoint -= damage;
                --obstacle.Quantity;
                if (!IsAlive())
                    break;
            }
        }

        return new DefaultResult();
    }

    protected int SetDamage(AbstractObstacle? obstacle)
    {
        if (obstacle is Asteroid) return AsteroidDamage;
        else if (obstacle is Meteorite) return MeteoriteDamage;
        else if (obstacle is SpaceWhale) return SpaceWhaleDamage;

        return 0;
    }
}