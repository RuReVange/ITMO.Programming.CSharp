using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class FifthTestCase
{
    [Fact]
    public void FifthTestCaseMethod()
    {
        int distance = 3000;
        var pathList = new List<(IEnvironment Environment, int Distance)>() { (new IncreasedDensityNebula(0), distance) };
        var spaceshipList = new List<AbstractSpaceship>() { new Augur(false), new Stella(false) };
        var path = new GlobalPath(pathList, spaceshipList);

        var resultList = new List<GlobalPathResult>(path.GlobalMovement());

        Assert.True(resultList[0].Result is ShipLoss && resultList[1].Result is RouteSuccess);
    }
}