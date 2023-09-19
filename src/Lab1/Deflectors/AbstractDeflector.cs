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
    protected int HealthPoint { get; init; }

    public bool IsAlive()
    {
        if (HealthPoint > 0) return true;
        return false;
    }

    // public void Destruction(class Obstacle){}
    //
    // В классе препятствие храним колличество препятствий
    // 1 класс на все препятствия
    // использовать pattern matching (с проверкой на is)
    // if (obstacle is meteorite)
}