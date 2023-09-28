namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public record Meteorite : AbstractObstacle
{
    public Meteorite(int quantity)
        : base(quantity) { }
}