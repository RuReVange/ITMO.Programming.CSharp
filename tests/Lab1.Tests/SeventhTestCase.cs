using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class SeventhTestCase
{
    [Fact]
    public void SeventhTestCaseMethod()
    {
        (int, int) distance = (100, 1000);
        var pathList = new List<(IEnvironment Environment, int Distance)>() { (new OrdinarySpace(15, 2), distance.Item1), (new OrdinarySpace(0, 10), distance.Item2) };
        var spaceshipList = new List<AbstractSpaceship>() { new Vaclas(false), new Augur(false), new Meridian(false) };
        var path = new GlobalPath(pathList, spaceshipList);

        var resultList = new List<GlobalPathResult>(path.GlobalMovement());

        Assert.True(resultList[0].Result is ShipDestruction && resultList[1].Result is RouteSuccess && resultList[2].Result is ShipDestruction);
        Assert.True(resultList[3].Result is ShipDestruction && resultList[4].Result is ShipDestruction && resultList[5].Result is ShipDestruction);
    }
}