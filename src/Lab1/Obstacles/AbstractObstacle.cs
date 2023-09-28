namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public abstract record AbstractObstacle
{
    protected AbstractObstacle() { }
    protected AbstractObstacle(int quantity)
    {
        Quantity = quantity;
    }

    public int Quantity { get; set; }
}