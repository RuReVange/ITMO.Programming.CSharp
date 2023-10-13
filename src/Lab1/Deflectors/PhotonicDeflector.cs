using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Result;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonicDeflector
{
    private const int MaxHealth = 3;
    private int HealthPoint { get; set; } = MaxHealth;
    public IResult TakeDamage(AntimatterFlares? antimatterFlare) // Attackuation
    {
        if (antimatterFlare is null) return new NullReference();

        if (antimatterFlare.Quantity > MaxHealth)
        {
            return new DeadShipsCrew();
        }
        else
        {
            HealthPoint -= antimatterFlare.Quantity;
            antimatterFlare.Quantity = 0;
        }

        return new DefaultSuccess();
    }

    private bool IsAlive()
    {
        return HealthPoint > 0;
    }
}