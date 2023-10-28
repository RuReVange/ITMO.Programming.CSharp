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

public class PersonalComputer : IPersonalComputer
{
    public PersonalComputer(IMotherboard? motherboard, ICpu? cpu, ICpuCooler? cpuCooler, IRam? ram, IVideocard? videocard, ISsd? ssd, IHdd? hdd, IPcCase? pcCase, IPowerSupplyUnit? powerSupplyUnit, IWiFiAdapter? wiFiAdapter)
    {
        ComponentType = "PersonalComputer";
        Motherboard = motherboard;
        Cpu = cpu;
        CpuCooler = cpuCooler;
        Ram = ram;
        Videocard = videocard;
        Ssd = ssd;
        Hdd = hdd;
        PcCase = pcCase;
        PowerSupplyUnit = powerSupplyUnit;
        WiFiAdapter = wiFiAdapter;
    }

    public string ComponentType { get; init; }
    public IMotherboard? Motherboard { get; init; }
    public ICpu? Cpu { get; init; }
    public ICpuCooler? CpuCooler { get; init; }
    public IRam? Ram { get; init; }
    public IVideocard? Videocard { get; init; }
    public ISsd? Ssd { get; init; }
    public IHdd? Hdd { get; init; }
    public IPcCase? PcCase { get; init; }
    public IPowerSupplyUnit? PowerSupplyUnit { get; init; }
    public IWiFiAdapter? WiFiAdapter { get; init; }
}