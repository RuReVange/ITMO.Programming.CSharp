using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class PromenadeShuttleAndAugurInIncreasedDensityNebulaMediumLengthRoute
{
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { new List<(IEnvironment, int)> { (new IncreasedDensityNebula(new List<AbstractObstacle>() { new AntimatterFlares(0) }), 3000) }, new List<AbstractSpaceship>() { new PromenadeShuttle(), new Augur(false) } };
    }

    [Theory]
    [MemberData(nameof(TestData))]

    private void TestMethod(IList<(IEnvironment Environment, int Distance)> pathList, IList<AbstractSpaceship> spaceshipList)
    {
        var path = new GlobalPath(pathList, spaceshipList);
        IList<GlobalPathResult> results;

        results = path.GlobalMovement();

        Assert.True(results[0].Result is ShipLoss && results[1].Result is ShipLoss);
    }
}