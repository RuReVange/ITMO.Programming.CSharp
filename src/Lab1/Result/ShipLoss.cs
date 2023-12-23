namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public record ShipLoss : IResult
{
    public string Message { get; init; } = "The spaceship was lost";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}