using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class IncreasedDensityNebula : IEnvironment
{
     public IncreasedDensityNebula(IList<AbstractObstacle> obstacleList)
     {
          ObstacleList = obstacleList;
     }

     public IList<AbstractObstacle> ObstacleList { get; init; }

     public IResult EnvironmentMovement(int distance, AbstractSpaceship spaceship)
     {
          IResult tmpResult = spaceship.SpaceshipTakeDamage(ObstacleList);
          return tmpResult is DefaultSuccess ? (spaceship.JumpEngine is not null ? spaceship.JumpEngine.Movement(distance) : new ShipLoss()) : tmpResult;
     }
}