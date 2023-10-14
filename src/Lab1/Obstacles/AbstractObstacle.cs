namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public abstract record AbstractObstacle
{
    protected AbstractObstacle() { }
    protected AbstractObstacle(int quantity = 0)
    {
        Quantity = quantity;
    }

    internal int Quantity { get; set; }
}