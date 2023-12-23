using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuCoolerDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.HddDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.MotherboardDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PowerSupplyUnitDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.RamDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.SsdDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.VideocardDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.WiFiAdapterDirectory;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.PersonalComputer;

public interface IPersonalComputerBuilder
{
    IPersonalComputerBuilder WithMotherboard(IMotherboard? motherboard);
    IPersonalComputerBuilder WithCpu(ICpu? cpu);
    IPersonalComputerBuilder WithCpuCooler(ICpuCooler? cpuCooler);
    IPersonalComputerBuilder WithRam(IRam? ram);
    IPersonalComputerBuilder WithVideocard(IVideocard? videocard);
    IPersonalComputerBuilder WithSsd(ISsd? ssd);
    IPersonalComputerBuilder WithHdd(IHdd? hdd);
    IPersonalComputerBuilder WithPcCase(IPcCase? pcCase);
    IPersonalComputerBuilder WithPowerSupplyUnit(IPowerSupplyUnit? powerSupplyUnit);
    IPersonalComputerBuilder WithWiFiAdapter(IWiFiAdapter? wiFiAdapter);
    void DeBuild(IPersonalComputer personalComputer);
    IPersonalComputer Build();
}