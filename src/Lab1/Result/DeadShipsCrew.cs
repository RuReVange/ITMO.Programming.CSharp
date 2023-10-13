namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public record DeadShipsCrew : IResult
{
    public string Message { get; init; } = "The ship's crew is dead";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}