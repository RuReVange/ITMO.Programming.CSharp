using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Result;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public abstract class AbstractSpaceship
{
    public AbstractImpulseEngine? ImpulseEngine { get; init; }
    public AbstractJumpEngine? JumpEngine { get; init; }
    public AbstractDeflector? Deflector { get; init; }
    public AbstractHull? Hull { get; init; }
    public bool AntiNeutrinoEmitter { get; init; }

    public IResult SpaceshipTakeDamage(IList<AbstractObstacle> obstacleList)
    {
        if (Deflector is not null)
        {
            if (obstacleList.Any(i => Deflector.TakeDamage(i) is DeadShipsCrew))
                return new DeadShipsCrew();
        }

        if (Hull is not null)
        {
            foreach (AbstractObstacle obstacle in obstacleList)
            {
                IResult tmpResult = Hull.TakeDamage(obstacle);
                if (tmpResult is DeadShipsCrew)
                {
                    return new DeadShipsCrew();
                }
                else if (tmpResult is ShipDestruction)
                {
                    return new ShipDestruction();
                }
            }
        }
        else
        {
            return new ShipDestruction();
        }

        return new DefaultSuccess();
    }
}