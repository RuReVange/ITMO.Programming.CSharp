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

public class PersonalComputerBuilder : IPersonalComputerBuilder
{
    private IMotherboard? _motherboard;
    private ICpu? _cpu;
    private ICpuCooler? _cpuCooler;
    private IRam? _ram;
    private IVideocard? _videocard;
    private ISsd? _ssd;
    private IHdd? _hdd;
    private IPcCase? _pcCase;
    private IPowerSupplyUnit? _powerSupplyUnit;
    private IWiFiAdapter? _wiFiAdapter;

    public IPersonalComputerBuilder WithMotherboard(IMotherboard? motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public IPersonalComputerBuilder WithCpu(ICpu? cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IPersonalComputerBuilder WithCpuCooler(ICpuCooler? cpuCooler)
    {
        _cpuCooler = cpuCooler;
        return this;
    }

    public IPersonalComputerBuilder WithRam(IRam? ram)
    {
        _ram = ram;
        return this;
    }

    public IPersonalComputerBuilder WithVideocard(IVideocard? videocard)
    {
        _videocard = videocard;
        return this;
    }

    public IPersonalComputerBuilder WithSsd(ISsd? ssd)
    {
        _ssd = ssd;
        return this;
    }

    public IPersonalComputerBuilder WithHdd(IHdd? hdd)
    {
        _hdd = hdd;
        return this;
    }

    public IPersonalComputerBuilder WithPcCase(IPcCase? pcCase)
    {
        _pcCase = pcCase;
        return this;
    }

    public IPersonalComputerBuilder WithPowerSupplyUnit(IPowerSupplyUnit? powerSupplyUnit)
    {
        _powerSupplyUnit = powerSupplyUnit;
        return this;
    }

    public IPersonalComputerBuilder WithWiFiAdapter(IWiFiAdapter? wiFiAdapter)
    {
        _wiFiAdapter = wiFiAdapter;
        return this;
    }

    public void DeBuild(IPersonalComputer personalComputer)
    {
        _motherboard = personalComputer.Motherboard;
        _cpu = personalComputer.Cpu;
        _cpuCooler = personalComputer.CpuCooler;
        _ram = personalComputer.Ram;
        _videocard = personalComputer.Videocard;
        _ssd = personalComputer.Ssd;
        _hdd = personalComputer.Hdd;
        _pcCase = personalComputer.PcCase;
        _powerSupplyUnit = personalComputer.PowerSupplyUnit;
        _wiFiAdapter = personalComputer.WiFiAdapter;
    }

    public IPersonalComputer Build()
    {
        return new PersonalComputer(
            _motherboard,
            _cpu,
            _cpuCooler,
            _ram,
            _videocard,
            _ssd,
            _hdd,
            _pcCase,
            _powerSupplyUnit,
            _wiFiAdapter);
    }
}