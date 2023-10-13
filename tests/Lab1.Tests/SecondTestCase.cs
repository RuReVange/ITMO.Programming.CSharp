using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class SecondTestCase
{
    // #pragma warning disable CA1024
    public static IEnumerable<object[]> DataSecondTestCase()
    {
        yield return new object[] { new List<(IEnvironment, int)> { (new IncreasedDensityNebula(2), 100) }, new List<AbstractSpaceship>() { new Vaclas(false), new Vaclas(true) } };
    }

    // #pragma warning restore CA1024
    [Theory]
    [MemberData(nameof(DataSecondTestCase))]
    private void SecondTestCaseMethod(IList<(IEnvironment Environment, int Distance)> pathList, IList<AbstractSpaceship> spaceshipList)
    {
        var path = new GlobalPath(pathList, spaceshipList);
        IList<GlobalPathResult> results;

        results = path.GlobalMovement();

        Assert.True(results[0].Result is DeadShipsCrew && results[1].Result is RouteSuccess);
    }
}