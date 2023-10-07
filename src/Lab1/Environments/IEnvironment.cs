using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public interface IEnvironment
{
    protected IEnumerable<AbstractObstacle> ObstacleList { get; init; }
    public IResult EnvironmentMovement(int distance, AbstractSpaceship spaceship);
}