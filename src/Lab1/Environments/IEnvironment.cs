using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public interface IEnvironment
{
    public IEnumerable<AbstractObstacle> ObstacleList { get; set; }
    internal IResult EnvironmentMovement(int distance, AbstractSpaceship spaceship);
}