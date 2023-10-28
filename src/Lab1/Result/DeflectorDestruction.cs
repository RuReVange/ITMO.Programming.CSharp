namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public record DeflectorDestruction : IResult
{
    public string Message { get; init; } = "The deflector was destroyed";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}