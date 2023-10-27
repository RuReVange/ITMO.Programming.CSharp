using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
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

public interface IPersonalComputer : IComponent
{
    IMotherboard? Motherboard { get; init; }
    ICpu? Cpu { get; init; }
    ICpuCooler? CpuCooler { get; init; }
    IRam? Ram { get; init; }
    IVideocard? Videocard { get; init; }
    ISsd? Ssd { get; init; }
    IHdd? Hdd { get; init; }
    IPcCase? PcCase { get; init; }
    IPowerSupplyUnit? PowerSupplyUnit { get; init; }
    IWiFiAdapter? WiFiAdapter { get; init; }
}