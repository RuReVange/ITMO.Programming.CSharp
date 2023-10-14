namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public record Asteroid : AbstractPhysicalObstacle
{
    public Asteroid(int quantity)
        : base(quantity) { }
}