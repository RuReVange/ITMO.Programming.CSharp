namespace Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

public record DeadShipsCrew : IResult
{
    public string Message { get; init; } = "The ship's crew is dead";
}