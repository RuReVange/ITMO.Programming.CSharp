namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public abstract record AbstractEnormousObstacle : AbstractObstacle
{
    protected AbstractEnormousObstacle(int quantity)
        : base(quantity) { }
}