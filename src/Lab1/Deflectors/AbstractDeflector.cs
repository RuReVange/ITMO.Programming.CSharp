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

    protected PhotonicDeflector? PhotonDeflector { get; init; }
    protected int AsteroidDamage { get; init; }
    protected int MeteoriteDamage { get; init; }
    protected int SpaceWhaleDamage { get; init; }
    protected int HealthPoint { get; set; }

    public IResult TakeDamage(AbstractObstacle? obstacle) // метод для подсчета урона
    {
        if (obstacle is null) return new NullReference();

        if (obstacle is AntimatterFlares flares)
        {
            return obstacle.Quantity > 0
                ? (PhotonDeflector is not null ? PhotonDeflector.TakeDamage(flares) : new DeadShipsCrew())
                : new DefaultSuccess();
        }
        else
        {
            int damage = SetDamage(obstacle);
            int tmpQuantity = obstacle.Quantity;

            // через цикл, потому что нужно отследить момент, когда Health перейдет в 0
            for (int i = 0; i < tmpQuantity; ++i)
            {
                if (!IsAlive())
                    return new DeflectorDestruction();
                HealthPoint -= damage;
                --obstacle.Quantity;
            }
        }

        return new DefaultSuccess();
    }

    private bool IsAlive()
    {
        return HealthPoint > 0;
    }

    private int SetDamage(AbstractObstacle? obstacle)
    {
        if (obstacle is Asteroid) return AsteroidDamage;
        else if (obstacle is Meteorite) return MeteoriteDamage;
        else if (obstacle is SpaceWhale) return SpaceWhaleDamage;

        return 0;
    }
}