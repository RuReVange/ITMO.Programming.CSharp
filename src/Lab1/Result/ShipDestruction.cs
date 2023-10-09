namespace Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

public class ShipDestruction : IResult
{
    public string Message { get; init; } = "The spaceship was destroyed";

    public int SpentTime { get; init; }
    public int SpentFuel { get; init; }
}