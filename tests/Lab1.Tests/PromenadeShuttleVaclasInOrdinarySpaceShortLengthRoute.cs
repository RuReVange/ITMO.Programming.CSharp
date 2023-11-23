using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class PromenadeShuttleVaclasInOrdinarySpaceShortLengthRoute
{
    [Fact]
    public void TestMethod()
    {
        int distance = 100;
        IList<AbstractObstacle> obstacleList = new List<AbstractObstacle>() { new Asteroid(0), new Meteorite(0) };
        var pathList = new List<(IEnvironment Environment, int Distance)>() { (new OrdinarySpace(obstacleList), distance) };
        var spaceshipList = new List<AbstractSpaceship>() { new PromenadeShuttle(), new Vaclas(false) };
        var path = new GlobalPath(pathList, spaceshipList);

        var resultList = new List<GlobalPathResult>(path.GlobalMovement());

        Assert.True(resultList[0].Result.SpentFuel < resultList[1].Result.SpentFuel && resultList[0].Spaceship is PromenadeShuttle && resultList[1].Spaceship is Vaclas);
    }
}