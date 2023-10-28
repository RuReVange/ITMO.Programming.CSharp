namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public record DefaultSuccess : IResult
{
    public string Message { get; init; } = "Success";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}