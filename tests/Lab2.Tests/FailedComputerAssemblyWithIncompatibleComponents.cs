using Itmo.ObjectOrientedProgramming.Lab2.Models.PersonalComputer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ResultType;
using Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Service;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class FailedComputerAssemblyWithIncompatibleComponents
{
    [Fact]
    public void TestMethod()
    {
        var repository = Repository.Instance();
        repository.GlobalInitialize();

        IPersonalComputerBuilder personalComputerBuilder = new PersonalComputerBuilder();
        personalComputerBuilder
            .WithMotherboard(repository.MotherboardsList[0])
            .WithCpu(repository.CpuList[1])
            .WithCpuCooler(repository.CpuCoolerList[0])
            .WithRam(repository.RamList[1])
            .WithVideocard(repository.VideocardList[1])
            .WithSsd(repository.SsdList[1])
            .WithHdd(repository.HddList[0])
            .WithPcCase(repository.PcCaseList[1])
            .WithWiFiAdapter(repository.WiFiAdapterList[0])
            .WithPowerSupplyUnit(repository.PowerSupplyUnitList[2]);

        IPersonalComputer personalComputer = personalComputerBuilder.Build();

        Result result = Validator.Validate(personalComputer);

        Assert.True(result.FinalResult is "Invalid build. The components are incompatible");
    }
}