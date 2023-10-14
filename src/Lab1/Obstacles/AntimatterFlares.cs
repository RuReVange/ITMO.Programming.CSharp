namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public record AntimatterFlares : AbstractImmaterialObstacle
{
    public AntimatterFlares(int quantity)
        : base(quantity) { }
}