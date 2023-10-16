using System;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Result;

public record GlobalPathResult(AbstractSpaceship Spaceship, IResult Result)
{
    public AbstractSpaceship Spaceship { get; init; } = Spaceship ?? throw new ArgumentNullException(nameof(Spaceship));
    public IResult Result { get; init; } = Result ?? throw new ArgumentNullException(nameof(Result));
}