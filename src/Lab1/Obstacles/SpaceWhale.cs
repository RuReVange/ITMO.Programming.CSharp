namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public record SpaceWhale : AbstractEnormousObstacle
{
    public SpaceWhale(int quantity)
        : base(quantity) { }
}