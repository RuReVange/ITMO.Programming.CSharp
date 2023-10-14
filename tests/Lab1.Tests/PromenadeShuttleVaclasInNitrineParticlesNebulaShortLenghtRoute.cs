using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class PromenadeShuttleVaclasInNitrineParticlesNebulaShortLenghtRoute
{
    [Fact]
    public void TestMethod()
    {
        const int distance = 100;
        IList<AbstractObstacle> obstacleList = new List<AbstractObstacle>() { new SpaceWhale(1) };
        var pathList = new List<(IEnvironment Environment, int Distance)>() { (new NitrineParticlesNebula(obstacleList), distance) };
        var spaceshipList = new List<AbstractSpaceship>() { new PromenadeShuttle(), new Vaclas(false) };
        var path = new GlobalPath(pathList, spaceshipList);

        var resultList = new List<GlobalPathResult>(path.GlobalMovement());

        Assert.True(resultList[0].Result is ShipDestruction && resultList[1].Result is RouteSuccess);
    }
}