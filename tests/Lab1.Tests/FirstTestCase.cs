using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class FirstTestCase
{
    public static IEnumerable<object[]> DataFirstTestCase()
    {
        yield return new object[] { new List<(IEnvironment, int)> { (new IncreasedDensityNebula(0), 3000) }, new List<AbstractSpaceship>() { new PromenadeShuttle(), new Augur(false) } };
    }

    [Theory]
    [MemberData(nameof(DataFirstTestCase))]

    private void FirstTestCaseMethod(IList<(IEnvironment Environment, int Distance)> pathList, IList<AbstractSpaceship> spaceshipList)
    {
        var path = new GlobalPath(pathList, spaceshipList);
        IList<(AbstractSpaceship, IResult)> results;

        results = path.GlobalMovement();

        Assert.True(results[0].Item2 is ShipLoss && results[1].Item2 is ShipLoss);
    }
}