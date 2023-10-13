using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Result;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class ThirdTestCase
{
    public static IEnumerable<object[]> DataThirdTestCase()
    {
        yield return new object[] { new List<(IEnvironment, int)> { (new NitrineParticlesNebula(2), 100) }, new List<AbstractSpaceship>() { new Vaclas(false), new Augur(false), new Meridian(false) } };
    }

    [Theory]
    [MemberData(nameof(DataThirdTestCase))]

    private void ThirdTestCaseMethod(IList<(IEnvironment Environment, int Distance)> pathList, IList<AbstractSpaceship> spaceshipList)
    {
        var path = new GlobalPath(pathList, spaceshipList);
        IList<GlobalPathResult> results;

        results = path.GlobalMovement();

        Assert.True(results[0].Result is ShipDestruction && results[1].Result is RouteSuccess && results[2].Result is RouteSuccess);
    }
}