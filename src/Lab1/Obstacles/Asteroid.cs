namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public record Asteroid : AbstractObstacle
{
    public Asteroid(int quantity)
        : base(quantity) { }
}