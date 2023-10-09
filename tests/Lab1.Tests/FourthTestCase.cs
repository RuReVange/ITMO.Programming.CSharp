using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
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

        var resultList = new List<(AbstractSpaceship Ship, IResult Result)>(path.GlobalMovement());

        Assert.True(resultList[0].Result.SpentFuel < resultList[1].Result.SpentFuel && resultList[0].Ship is PromenadeShuttle && resultList[1].Ship is Vaclas);
    }
}