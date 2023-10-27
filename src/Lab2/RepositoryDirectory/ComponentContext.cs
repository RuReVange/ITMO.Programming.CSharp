using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;
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
using Itmo.ObjectOrientedProgramming.Lab2.Models.PersonalComputer;

namespace Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;

public class ComponentContext
{
    private IList<Bios> _biosList;
    private IList<Xmp> _xmpList;

    public ComponentContext()
    {
        _biosList = new List<Bios>();
        _xmpList = new List<Xmp>();
        CpuList = new List<ICpu>();
        CpuCoolerList = new List<ICpuCooler>();
        RamList = new List<IRam>();
        VideocardList = new List<IVideocard>();
        SsdList = new List<ISsd>();
        HddList = new List<IHdd>();
        PcCaseList = new List<IPcCase>();
        PowerSupplyUnitList = new List<IPowerSupplyUnit>();
        WiFiAdapterList = new List<IWiFiAdapter>();
        MotherboardsList = new List<IMotherboard>();
        PersonalComputerList = new List<IPersonalComputer>();

        GlobalInitialize();
    }

    public IList<IMotherboard> MotherboardsList { get; init; }
    public IList<ICpu> CpuList { get; init; }
    public IList<ICpuCooler> CpuCoolerList { get; init; }
    public IList<IRam> RamList { get; init; }
    public IList<IVideocard> VideocardList { get; init; }
    public IList<ISsd> SsdList { get; init; }
    public IList<IHdd> HddList { get; init; }
    public IList<IPcCase> PcCaseList { get; init; }
    public IList<IPowerSupplyUnit> PowerSupplyUnitList { get; init; }
    public IList<IWiFiAdapter> WiFiAdapterList { get; init; }
    public IList<IPersonalComputer> PersonalComputerList { get; init; }

    public void GlobalInitialize()
    {
        ComponentInitializer.BiosInitializer(_biosList);
        ComponentInitializer.XmpInitializer(_xmpList);
        ComponentInitializer.MotherboardInitializer(MotherboardsList, _biosList);
        ComponentInitializer.CpuInitializer(CpuList);
        ComponentInitializer.CpuCoolerInitializer(CpuCoolerList);
        ComponentInitializer.VideocardInitializer(VideocardList);
        ComponentInitializer.SsdInitializer(SsdList);
        ComponentInitializer.HddInitializer(HddList);
        ComponentInitializer.PcCasesInitializer(PcCaseList);
        ComponentInitializer.PowerSupplyUnitInitializer(PowerSupplyUnitList);
        ComponentInitializer.RamInitializer(RamList, _xmpList);
        ComponentInitializer.WiFiAdapterInitializer(WiFiAdapterList);
    }
}