namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public abstract record AbstractImmaterialObstacle : AbstractObstacle
{
    protected AbstractImmaterialObstacle(int quantity)
        : base(quantity) { }
}