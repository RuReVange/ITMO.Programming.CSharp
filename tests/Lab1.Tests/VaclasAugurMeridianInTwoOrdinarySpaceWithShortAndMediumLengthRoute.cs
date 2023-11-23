using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class VaclasAugurMeridianInTwoOrdinarySpaceWithShortAndMediumLengthRoute
{
    [Fact]
    public void TestMethod()
    {
        (int, int) distance = (100, 1000);
        IList<AbstractObstacle> obstacleListFirst = new List<AbstractObstacle>() { new Asteroid(15), new Meteorite(2) };
        IList<AbstractObstacle> obstacleListSecond = new List<AbstractObstacle>() { new Asteroid(0), new Meteorite(10) };

        var pathList = new List<(IEnvironment Environment, int Distance)>() { (new OrdinarySpace(obstacleListFirst), distance.Item1), (new OrdinarySpace(obstacleListSecond), distance.Item2) };
        var spaceshipList = new List<AbstractSpaceship>() { new Vaclas(false), new Augur(false), new Meridian(false) };
        var path = new GlobalPath(pathList, spaceshipList);

        var resultList = new List<GlobalPathResult>(path.GlobalMovement());

        Assert.True(resultList[0].Result is ShipDestruction && resultList[1].Result is RouteSuccess && resultList[2].Result is ShipDestruction);
        Assert.True(resultList[3].Result is ShipDestruction && resultList[4].Result is ShipDestruction && resultList[5].Result is ShipDestruction);
    }
}