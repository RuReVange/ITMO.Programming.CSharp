namespace Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

public class NullReference : IResult
{
    public string Message { get; init; } = "The object has null reference";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}