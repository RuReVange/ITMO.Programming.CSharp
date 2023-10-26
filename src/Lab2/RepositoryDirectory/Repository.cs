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

public class Repository
{
    private static Repository? _instance;

    private readonly IMotherboardBuilder _motherboardBuilder;
    private readonly ICpuBuilder _cpuBuilder;
    private readonly ICpuCoolerBuilder _cpuCoolerBuilder;
    private readonly IRamBuilder _ramBuilder;
    private readonly IVideocardBuilder _videocardBuilder;
    private readonly ISsdBuilder _ssdBuilder;
    private readonly IHddBuilder _hddBuilder;
    private readonly IPcCaseBuilder _pcCaseBuilder;
    private readonly IPowerSupplyUnitBuilder _powerSupplyUnitBuilder;
    private readonly IWiFiAdapterBuilder _wiFiAdapterBuilder;

    private Repository()
    {
        _motherboardBuilder = new MotherboardBuilder();
        _cpuBuilder = new CpuBuilder();
        _cpuCoolerBuilder = new CpuCoolerBuilder();
        _ramBuilder = new RamBuilder();
        _videocardBuilder = new VideocardBuilder();
        _ssdBuilder = new SsdBuilder();
        _hddBuilder = new HddBuilder();
        _pcCaseBuilder = new PcCaseBuilder();
        _powerSupplyUnitBuilder = new PowerSupplyUnitBuilder();
        _wiFiAdapterBuilder = new WiFiAdapterBuilder();
    }

    public IList<IPersonalComputer> PersonalComputersList { get; init; } = new List<IPersonalComputer>();
    public IList<IMotherboard> MotherboardsList { get; init; } = new List<IMotherboard>();
    public IList<ICpu> CpuList { get; init; } = new List<ICpu>();
    public IList<ICpuCooler> CpuCoolerList { get; init; } = new List<ICpuCooler>();
    public IList<IRam> RamList { get; init; } = new List<IRam>();
    public IList<IVideocard> VideocardList { get; init; } = new List<IVideocard>();
    public IList<ISsd> SsdList { get; init; } = new List<ISsd>();
    public IList<IHdd> HddList { get; init; } = new List<IHdd>();
    public IList<IPcCase> PcCaseList { get; init; } = new List<IPcCase>();
    public IList<IPowerSupplyUnit> PowerSupplyUnitList { get; init; } = new List<IPowerSupplyUnit>();
    public IList<IWiFiAdapter> WiFiAdapterList { get; init; } = new List<IWiFiAdapter>();

    private IList<Bios> BiosList { get; init; } = new List<Bios>()
    {
        new Bios("UEFI", "7D32VHE", new List<string>() { "LGA 1700" }),
        new Bios("UEFI", "7C95V251", new List<string>() { "AM4" }),
        new Bios("ACI", "7E68V113", new List<string>() { "LGA 1200" }),
    };
    private IList<Xmp> XmpList { get; init; } = new List<Xmp>()
    {
        new Xmp("16-20-20", 1.35, 3200),
        new Xmp("16-18-18", 1.25, 3200),
        new Xmp("40-40-40", 1.25, 5600),
        new Xmp("18-22-22", 1.3, 3600),
        new Xmp("11-11-11-28", 1.1, 1600),
        new Xmp("16-18-18-35", 1.15, 2666),
    };

    public static Repository Instance()
    {
        return _instance ??= new Repository();
    }

    public void GlobalInitialize()
    {
        MotherboardInitializer();
        CpuInitializer();
        CpuCoolerInitializer();
        VideocardInitializer();
        SsdInitializer();
        HddInitializer();
        PcCasesInitializer();
        PowerSupplyUnitInitializer();
        RamInitializer();
        WiFiAdapterInitializer();
    }

    private void MotherboardInitializer()
    {
        MotherboardsList.Add(
            _motherboardBuilder.WithSocket("LGA 1700")
                .WithPcieLineQty(4)
                .WithSataPortQty(6)
                .WithChipset(new Chipset(true, new List<int>() { 5600, 5800, 6000, 6200, 6400 }))
                .WithSupportedDdrStandard("DDR5")
                .WithRamSlots(4)
                .WithBios(BiosList[0])
                .WithFormFactor(new FormFactor(305, 15, 244))
                .Build());
        MotherboardsList.Add(
            _motherboardBuilder.WithSocket("AM4")
                .WithPcieLineQty(3)
                .WithSataPortQty(6)
                .WithChipset(new Chipset(true, new List<int>() { 3200, 3466, 3600, 3733, 3800, 3866, 4000, 4133, 4200, 4266, 4333, 4400, 4466, 4533, 4600, 4666, 4733 }))
                .WithSupportedDdrStandard("DDR4")
                .WithRamSlots(4)
                .WithBios(BiosList[1])
                .WithFormFactor(new FormFactor(244, 14, 244))
                .Build());
        MotherboardsList.Add(
            _motherboardBuilder.WithSocket("LGA 1155")
                .WithPcieLineQty(2)
                .WithSataPortQty(4)
                .WithChipset(new Chipset(false, new List<int>() { 1600 }))
                .WithSupportedDdrStandard("DDR3")
                .WithRamSlots(2)
                .WithBios(BiosList[2])
                .WithFormFactor(new FormFactor(191, 15, 170))
                .Build());
    }

    private void CpuInitializer()
    {
        CpuList.Add(
            _cpuBuilder.WithSocket("LGA 1700")
                .WithCoreQty(6)
                .WithCoreFrequency(2.5f)
                .WithVideoCore(false)
                .WithSupportedMemoryFrequency(new List<int>() { 4800, 3200 })
                .WithTdp(65)
                .WithPowerConsumption(260)
                .Build());
        CpuList.Add(
            _cpuBuilder.WithSocket("AM4")
                .WithCoreQty(6)
                .WithCoreFrequency(3.9f)
                .WithVideoCore(true)
                .WithSupportedMemoryFrequency(new List<int>() { 3200 })
                .WithTdp(65)
                .WithPowerConsumption(88)
                .Build());
        CpuList.Add(
            _cpuBuilder.WithSocket("LGA 1700")
                .WithCoreQty(24)
                .WithCoreFrequency(3f)
                .WithVideoCore(true)
                .WithSupportedMemoryFrequency(new List<int>() { 5600, 3200 })
                .WithTdp(125)
                .WithPowerConsumption(350)
                .Build());
        CpuList.Add(
            _cpuBuilder.WithSocket("LGA 1200")
                .WithCoreQty(4)
                .WithCoreFrequency(3.6f)
                .WithVideoCore(false)
                .WithSupportedMemoryFrequency(new List<int>() { 2666 })
                .WithTdp(65)
                .WithPowerConsumption(148)
                .Build());
        CpuList.Add(
            _cpuBuilder.WithSocket("LGA 1200")
                .WithCoreQty(2)
                .WithCoreFrequency(3.5f)
                .WithVideoCore(true)
                .WithSupportedMemoryFrequency(new List<int>() { 2666 })
                .WithTdp(58)
                .WithPowerConsumption(17)
                .Build());
        CpuList.Add(
            _cpuBuilder.WithSocket("AM4")
                .WithCoreQty(16)
                .WithCoreFrequency(3.4f)
                .WithVideoCore(false)
                .WithSupportedMemoryFrequency(new List<int>() { 3200 })
                .WithTdp(105)
                .WithPowerConsumption(142)
                .Build());
    }

    private void CpuCoolerInitializer()
    {
        CpuCoolerList.Add(
            _cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM2", "AM2+", "AM3", "AM3+", "AM4", "AM5", "FM1", "FM2", "FM2+", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700", "LGA 2011", "LGA 2011-3", "LGA 2066" })
                .WithMaxTdp(260)
                .WithFormFactor(new FormFactor(129, 160, 138))
                .Build());
        CpuCoolerList.Add(
            _cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM4", "AM5", "FM1", "FM2", "FM2+", "LGA 1150", "LGA 1151", "LGA 1151-v2", "LGA 1155", "LGA 1200", "LGA 1700" })
                .WithMaxTdp(180)
                .WithFormFactor(new FormFactor(129, 158, 103))
                .Build());
        CpuCoolerList.Add(
            _cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1151-v2", "LGA 1156", "LGA 1200", "LGA 1700" })
                .WithMaxTdp(120)
                .WithFormFactor(new FormFactor(121, 136, 76))
                .Build());
        CpuCoolerList.Add(
            _cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700" })
                .WithMaxTdp(200)
                .WithFormFactor(new FormFactor(125, 155, 96))
                .Build());
    }

    private void VideocardInitializer()
    {
        VideocardList.Add(
            _videocardBuilder.WithVideoCardMemorySize(8)
                .WithPcieVersion(4)
                .WithGpuFrequency(1410)
                .WithPowerConsumption(256)
                .WithFormFactor(new FormFactor(118, 53, 294))
                .Build());
        VideocardList.Add(
            _videocardBuilder.WithVideoCardMemorySize(4)
                .WithPcieVersion(3)
                .WithGpuFrequency(1410)
                .WithPowerConsumption(90)
                .WithFormFactor(new FormFactor(111, 33, 200))
                .Build());
        VideocardList.Add(
            _videocardBuilder.WithVideoCardMemorySize(12)
                .WithPcieVersion(4)
                .WithGpuFrequency(2310)
                .WithPowerConsumption(285)
                .WithFormFactor(new FormFactor(133, 64, 329))
                .Build());
        VideocardList.Add(
            _videocardBuilder.WithVideoCardMemorySize(8)
                .WithPcieVersion(4)
                .WithGpuFrequency(2310)
                .WithPowerConsumption(160)
                .WithFormFactor(new FormFactor(124, 41, 250))
                .Build());
        VideocardList.Add(
            _videocardBuilder.WithVideoCardMemorySize(24)
                .WithPcieVersion(4)
                .WithGpuFrequency(2230)
                .WithPowerConsumption(450)
                .WithFormFactor(new FormFactor(136, 62, 322))
                .Build());
    }

    private void SsdInitializer()
    {
        SsdList.Add(
            _ssdBuilder.WithConnectionOption("SATA")
                .WithMemorySize(1000)
                .WithMaxOperatingSpeed(560)
                .WithPowerConsumption(4)
                .Build());
        SsdList.Add(
            _ssdBuilder.WithConnectionOption("SATA")
                .WithMemorySize(240)
                .WithMaxOperatingSpeed(520)
                .WithPowerConsumption(2)
                .Build());
        SsdList.Add(
            _ssdBuilder.WithConnectionOption("SATA")
                .WithMemorySize(960)
                .WithMaxOperatingSpeed(550)
                .WithPowerConsumption(4)
                .Build());
        SsdList.Add(
            _ssdBuilder.WithConnectionOption("PCI-E")
                .WithMemorySize(500)
                .WithMaxOperatingSpeed(3500)
                .WithPowerConsumption(9)
                .Build());
        SsdList.Add(
            _ssdBuilder.WithConnectionOption("PCI-E")
                .WithMemorySize(1024)
                .WithMaxOperatingSpeed(7000)
                .WithPowerConsumption(6)
                .Build());
    }

    private void HddInitializer()
    {
        HddList.Add(
            _hddBuilder.WithMemorySize(2000)
                .WithSpindleRotationSpeed(7200)
                .WithPowerConsumption(4)
                .Build());
        HddList.Add(
            _hddBuilder.WithMemorySize(4000)
                .WithSpindleRotationSpeed(5400)
                .WithPowerConsumption(5)
                .Build());
        HddList.Add(
            _hddBuilder.WithMemorySize(1000)
                .WithSpindleRotationSpeed(7200)
                .WithPowerConsumption(7)
                .Build());
        HddList.Add(
            _hddBuilder.WithMemorySize(6000)
                .WithSpindleRotationSpeed(5400)
                .WithPowerConsumption(5)
                .Build());
        HddList.Add(
            _hddBuilder.WithMemorySize(18000)
                .WithSpindleRotationSpeed(7200)
                .WithPowerConsumption(8)
                .Build());
    }

    private void PcCasesInitializer()
    {
        PcCaseList.Add(
            _pcCaseBuilder.WithFormFactor(new FormFactor(260, 496, 465))
                .WithMaxVideoCardFormFactor(new FormFactor(140, 70, 390))
                .WithSupportedMotherboardFormFactor(new FormFactor(250, 50, 310))
                .Build());
        PcCaseList.Add(
            _pcCaseBuilder.WithFormFactor(new FormFactor(310, 523, 526))
                .WithMaxVideoCardFormFactor(new FormFactor(207, 94, 435))
                .WithSupportedMotherboardFormFactor(new FormFactor(308, 57, 255))
                .Build());
        PcCaseList.Add(
            _pcCaseBuilder.WithFormFactor(new FormFactor(157, 360, 360))
                .WithMaxVideoCardFormFactor(new FormFactor(105, 64, 300))
                .WithSupportedMotherboardFormFactor(new FormFactor(203, 48, 179))
                .Build());
        PcCaseList.Add(
            _pcCaseBuilder.WithFormFactor(new FormFactor(204, 479, 445))
                .WithMaxVideoCardFormFactor(new FormFactor(205, 87, 360))
                .WithSupportedMotherboardFormFactor(new FormFactor(289, 68, 311))
                .Build());
        PcCaseList.Add(
            _pcCaseBuilder.WithFormFactor(new FormFactor(238, 523, 526))
                .WithMaxVideoCardFormFactor(new FormFactor(211, 92, 435))
                .WithSupportedMotherboardFormFactor(new FormFactor(313, 78, 255))
                .Build());
    }

    private void PowerSupplyUnitInitializer()
    {
        PowerSupplyUnitList.Add(
        _powerSupplyUnitBuilder.WithPeakPower(400)
            .Build());
        PowerSupplyUnitList.Add(
            _powerSupplyUnitBuilder.WithPeakPower(600)
                .Build());
        PowerSupplyUnitList.Add(
            _powerSupplyUnitBuilder.WithPeakPower(800)
                .Build());
        PowerSupplyUnitList.Add(
            _powerSupplyUnitBuilder.WithPeakPower(900)
                .Build());
        PowerSupplyUnitList.Add(
            _powerSupplyUnitBuilder.WithPeakPower(1000)
                .Build());
    }

    private void RamInitializer()
    {
        RamList.Add(
            _ramBuilder.WithMemorySize(16)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(1066, 1.2), new RamMemoryFrequencyAndVoltage(2066, 1.25), new RamMemoryFrequencyAndVoltage(3066, 1.3) })
                .WithFormFactor(new FormFactor(6, 34, 150))
                .WithDdrStandard("DDR4")
                .WithPowerConsumption(1.35)
                .WithSupportedXmpProfile(XmpList[0])
                .Build());
        RamList.Add(
            _ramBuilder.WithMemorySize(16)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(2066, 1.25), new RamMemoryFrequencyAndVoltage(3066, 1.3) })
                .WithFormFactor(new FormFactor(6, 35, 150))
                .WithDdrStandard("DDR5")
                .WithPowerConsumption(1.25)
                .WithSupportedXmpProfile(XmpList[2])
                .Build());
        RamList.Add(
            _ramBuilder.WithMemorySize(16)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(1066, 1.2), new RamMemoryFrequencyAndVoltage(2066, 1.25) })
                .WithFormFactor(new FormFactor(6, 34, 150))
                .WithDdrStandard("DDR4")
                .WithPowerConsumption(1.45)
                .WithSupportedXmpProfile(XmpList[2])
                .Build());
        RamList.Add(
            _ramBuilder.WithMemorySize(8)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(1066, 1.2) })
                .WithFormFactor(new FormFactor(6, 30, 150))
                .WithDdrStandard("DDR3")
                .WithPowerConsumption(1.1)
                .WithSupportedXmpProfile(XmpList[2])
                .Build());
    }

    private void WiFiAdapterInitializer()
    {
        WiFiAdapterList.Add(
            _wiFiAdapterBuilder.WithWiFiStandardVersion("802.11ac")
                .WithPcieVersion(4)
                .WithIsBluetoothModule(true)
                .WithPowerConsumption(5)
                .Build());
        WiFiAdapterList.Add(
            _wiFiAdapterBuilder.WithWiFiStandardVersion("802.11ax")
                .WithPcieVersion(4)
                .WithIsBluetoothModule(true)
                .WithPowerConsumption(8)
                .Build());
        WiFiAdapterList.Add(
            _wiFiAdapterBuilder.WithWiFiStandardVersion("802.11n")
                .WithPcieVersion(4)
                .WithIsBluetoothModule(false)
                .WithPowerConsumption(5)
                .Build());
        WiFiAdapterList.Add(
            _wiFiAdapterBuilder.WithWiFiStandardVersion("802.11n")
                .WithPcieVersion(3)
                .WithIsBluetoothModule(false)
                .WithPowerConsumption(4)
                .Build());
    }
}