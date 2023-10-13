using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class FourthTestCase
{
    [Fact]
    public void FourthTestCaseMethod()
    {
        int distance = 100;
        var pathList = new List<(IEnvironment Environment, int Distance)>() { (new OrdinarySpace(0, 0), distance) };
        var spaceshipList = new List<AbstractSpaceship>() { new PromenadeShuttle(), new Vaclas(false) };
        var path = new GlobalPath(pathList, spaceshipList);

        var resultList = new List<GlobalPathResult>(path.GlobalMovement());

        Assert.True(resultList[0].Result.SpentFuel < resultList[1].Result.SpentFuel && resultList[0].Spaceship is PromenadeShuttle && resultList[1].Spaceship is Vaclas);
    }
}