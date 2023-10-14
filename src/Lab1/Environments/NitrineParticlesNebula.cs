using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class NitrineParticlesNebula : IEnvironment
{
    public NitrineParticlesNebula(IList<AbstractObstacle> obstacleList)
    {
        ObstacleList = obstacleList;
    }

    public IList<AbstractObstacle> ObstacleList { get; init; }

    public IResult EnvironmentMovement(int distance, AbstractSpaceship spaceship)
    {
        if (spaceship.ImpulseEngine is ImpulseEngineC) distance *= 3;

        if (spaceship.AntiNeutrinoEmitter)
        {
            foreach (AbstractObstacle obstacle in ObstacleList)
                obstacle.Quantity = 0;
        }

        IResult tmpResult = spaceship.SpaceshipTakeDamage(ObstacleList);
        return tmpResult is DefaultSuccess ? (spaceship.ImpulseEngine is not null ? spaceship.ImpulseEngine.Movement(distance) : new ShipLoss()) : tmpResult;
    }
}