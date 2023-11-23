namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public interface IResult
{
    public string Message { get; }
    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}