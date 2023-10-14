using System.Collections.Generic;
using System.Linq;
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
          if (spaceship.JumpEngine is null) return new ShipLoss();

          if (spaceship.Deflector is not null)
          {
               if (ObstacleList.Any(i => spaceship.Deflector.TakeDamage(i) is DeadShipsCrew))
                    return new DeadShipsCrew();
          }

          if (spaceship.Hull is not null)
          {
               if (ObstacleList.Any(i => spaceship.Hull.TakeDamage(i) is DeadShipsCrew))
                    return new DeadShipsCrew();
          }
          else
          {
               return new ShipDestruction();
          }

          return spaceship.JumpEngine.Movement(distance);
     }
}