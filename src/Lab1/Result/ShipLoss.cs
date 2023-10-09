namespace Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

public class ShipLoss : IResult
{
    public string Message { get; init; } = "The spaceship was lost";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}