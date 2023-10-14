namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public record Meteorite : AbstractPhysicalObstacle
{
    public Meteorite(int quantity)
        : base(quantity) { }
}