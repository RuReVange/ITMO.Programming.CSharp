namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public abstract record AbstractPhysicalObstacle : AbstractObstacle
{
    protected AbstractPhysicalObstacle(int quantity)
        : base(quantity) { }
}