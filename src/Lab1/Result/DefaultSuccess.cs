namespace Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

public class DefaultSuccess : IResult
{
    public string Message { get; init; } = "Success";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}