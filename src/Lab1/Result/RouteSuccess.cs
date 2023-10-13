namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public record RouteSuccess : IResult
{
    public RouteSuccess(int spentTime, int spentFuel)
    {
        SpentTime = spentTime;
        SpentFuel = spentFuel;
    }

    public string Message { get; init; } = "Success";
    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}