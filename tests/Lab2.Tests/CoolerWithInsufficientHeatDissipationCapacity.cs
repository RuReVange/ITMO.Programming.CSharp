using Itmo.ObjectOrientedProgramming.Lab2.Models.PersonalComputer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ResultType;
using Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Service;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class CoolerWithInsufficientHeatDissipationCapacity
{
    [Fact]
    public void TestMethod()
    {
        var repository = Repository.Instance();

        IPersonalComputerBuilder personalComputerBuilder = new PersonalComputerBuilder();
        personalComputerBuilder
            .WithMotherboard(repository.Context.MotherboardsList[0])
            .WithCpu(repository.Context.CpuList[2])
            .WithCpuCooler(repository.Context.CpuCoolerList[2])
            .WithRam(repository.Context.RamList[1])
            .WithVideocard(repository.Context.VideocardList[1])
            .WithSsd(repository.Context.SsdList[1])
            .WithHdd(repository.Context.HddList[0])
            .WithPcCase(repository.Context.PcCaseList[1])
            .WithWiFiAdapter(repository.Context.WiFiAdapterList[0])
            .WithPowerSupplyUnit(repository.Context.PowerSupplyUnitList[2]);

        IPersonalComputer personalComputer = personalComputerBuilder.Build();

        repository.Add<IPersonalComputer>(repository.Context.PersonalComputerList, personalComputer);
        Result result = Validator.Validate(personalComputer);

        Assert.True(result.FinalResult is "Warranty obligations are denied. Some components may be unstable");
    }
}