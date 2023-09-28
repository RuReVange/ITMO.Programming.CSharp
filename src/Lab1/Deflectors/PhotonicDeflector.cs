using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonicDeflector
{
    private const int MaxHealth = 3;
    public PhotonicDeflector()
    {
        HealthPoint = MaxHealth;
    }

    protected int HealthPoint { get; set; }
    public static void Destruction(AntimatterFlares antimatterFlare) // Attackuation // В параметрах поставить класс Obstacle
    {
        if (antimatterFlare != null && antimatterFlare.Quantity > MaxHealth)
        {
            throw new AntimatterFlareException("The ship's crew are dead");

            // return exeption "гибель экипажа"
        }
    }

    public bool IsAlive()
    {
        if (HealthPoint > 0) return true;
        return false;
    }
}