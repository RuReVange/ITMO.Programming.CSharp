using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class OrdinarySpace : IEnvironment
{
    public OrdinarySpace(IList<AbstractObstacle> obstacleList)
    {
        ObstacleList = obstacleList;
    }

    public IList<AbstractObstacle> ObstacleList { get; init; }

    public IResult EnvironmentMovement(int distance, AbstractSpaceship spaceship)
    {
        if (spaceship.ImpulseEngine is null) return new ShipLoss();

        if (spaceship.Deflector is not null)
        {
            foreach (AbstractObstacle i in ObstacleList)
                spaceship.Deflector.TakeDamage(i);
        }

        if (spaceship.Hull is not null)
        {
            if (ObstacleList.Any(i => spaceship.Hull.TakeDamage(i) is ShipDestruction))
                return new ShipDestruction();
        }
        else
        {
            return new ShipDestruction();
        }

        return spaceship.ImpulseEngine.Movement(distance);
    }
}