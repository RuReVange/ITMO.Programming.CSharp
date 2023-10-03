using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonicDeflector
{
    private const int MaxHealth = 3;
    private int HealthPoint { get; set; } = MaxHealth;
    public void TakeDamage(AntimatterFlares? antimatterFlare) // Attackuation // В параметрах поставить класс Obstacle
    {
        if (antimatterFlare is null) return;

        if (antimatterFlare.Quantity > MaxHealth)
        {
            throw new AntimatterFlareException("The ship's crew are dead");
        }
        else
        {
            HealthPoint -= antimatterFlare.Quantity;
        }
    }

    public bool IsAlive()
    {
        return HealthPoint > 0;
    }
}