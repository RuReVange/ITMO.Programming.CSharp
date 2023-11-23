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

namespace Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;

public static class ComponentInitializer
{
    public static void BiosInitializer(IList<Bios> biosList)
    {
        biosList.Add(new Bios("UEFI", "7D32VHE", new List<string>() { "LGA 1700" }));
        biosList.Add(new Bios("UEFI", "7C95V251", new List<string>() { "AM4" }));
        biosList.Add(new Bios("ACI", "7E68V113", new List<string>() { "LGA 1200" }));
    }

    public static void XmpInitializer(IList<Xmp> xmpList)
    {
        xmpList.Add(new Xmp("16-20-20", 1.35, 3200));
        xmpList.Add(new Xmp("16-18-18", 1.25, 3200));
        xmpList.Add(new Xmp("40-40-40", 1.25, 5600));
        xmpList.Add(new Xmp("18-22-22", 1.3, 3600));
        xmpList.Add(new Xmp("11-11-11-28", 1.1, 1600));
        xmpList.Add(new Xmp("16-18-18-35", 1.15, 2666));
    }

    public static void MotherboardInitializer(IList<IMotherboard> motherboardsList, IList<Bios> biosList)
    {
        IMotherboardBuilder motherboardBuilder = new MotherboardBuilder();

        motherboardsList.Add(
            motherboardBuilder.WithSocket("LGA 1700")
                .WithPcieLineQty(4)
                .WithSataPortQty(6)
                .WithChipset(new Chipset(true, new List<int>() { 5600, 5800, 6000, 6200, 6400 }))
                .WithSupportedDdrStandard("DDR5")
                .WithRamSlots(4)
                .WithBios(biosList[0])
                .WithFormFactor(new FormFactor(305, 15, 244))
                .Build());
        motherboardsList.Add(
            motherboardBuilder.WithSocket("AM4")
                .WithPcieLineQty(3)
                .WithSataPortQty(6)
                .WithChipset(new Chipset(true, new List<int>() { 3200, 3466, 3600, 3733, 3800, 3866, 4000, 4133, 4200, 4266, 4333, 4400, 4466, 4533, 4600, 4666, 4733 }))
                .WithSupportedDdrStandard("DDR4")
                .WithRamSlots(4)
                .WithBios(biosList[1])
                .WithFormFactor(new FormFactor(244, 14, 244))
                .Build());
        motherboardsList.Add(
            motherboardBuilder.WithSocket("LGA 1155")
                .WithPcieLineQty(2)
                .WithSataPortQty(4)
                .WithChipset(new Chipset(false, new List<int>() { 1600 }))
                .WithSupportedDdrStandard("DDR3")
                .WithRamSlots(2)
                .WithBios(biosList[2])
                .WithFormFactor(new FormFactor(191, 15, 170))
                .Build());
    }

    public static void CpuInitializer(IList<ICpu> cpuList)
    {
        ICpuBuilder cpuBuilder = new CpuBuilder();

        cpuList.Add(
            cpuBuilder.WithSocket("LGA 1700")
                .WithCoreQty(6)
                .WithCoreFrequency(2.5f)
                .WithVideoCore(false)
                .WithSupportedMemoryFrequency(new List<int>() { 4800, 3200 })
                .WithTdp(65)
                .WithPowerConsumption(260)
                .Build());
        cpuList.Add(
            cpuBuilder.WithSocket("AM4")
                .WithCoreQty(6)
                .WithCoreFrequency(3.9f)
                .WithVideoCore(true)
                .WithSupportedMemoryFrequency(new List<int>() { 3200 })
                .WithTdp(65)
                .WithPowerConsumption(88)
                .Build());
        cpuList.Add(
            cpuBuilder.WithSocket("LGA 1700")
                .WithCoreQty(24)
                .WithCoreFrequency(3f)
                .WithVideoCore(true)
                .WithSupportedMemoryFrequency(new List<int>() { 5600, 3200 })
                .WithTdp(125)
                .WithPowerConsumption(350)
                .Build());
        cpuList.Add(
            cpuBuilder.WithSocket("LGA 1200")
                .WithCoreQty(4)
                .WithCoreFrequency(3.6f)
                .WithVideoCore(false)
                .WithSupportedMemoryFrequency(new List<int>() { 2666 })
                .WithTdp(65)
                .WithPowerConsumption(148)
                .Build());
        cpuList.Add(
            cpuBuilder.WithSocket("LGA 1200")
                .WithCoreQty(2)
                .WithCoreFrequency(3.5f)
                .WithVideoCore(true)
                .WithSupportedMemoryFrequency(new List<int>() { 2666 })
                .WithTdp(58)
                .WithPowerConsumption(17)
                .Build());
        cpuList.Add(
            cpuBuilder.WithSocket("AM4")
                .WithCoreQty(16)
                .WithCoreFrequency(3.4f)
                .WithVideoCore(false)
                .WithSupportedMemoryFrequency(new List<int>() { 3200 })
                .WithTdp(105)
                .WithPowerConsumption(142)
                .Build());
    }

    public static void CpuCoolerInitializer(IList<ICpuCooler> cpuCoolerList)
    {
        ICpuCoolerBuilder cpuCoolerBuilder = new CpuCoolerBuilder();

        cpuCoolerList.Add(
            cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM2", "AM2+", "AM3", "AM3+", "AM4", "AM5", "FM1", "FM2", "FM2+", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700", "LGA 2011", "LGA 2011-3", "LGA 2066" })
                .WithMaxTdp(260)
                .WithFormFactor(new FormFactor(129, 160, 138))
                .Build());
        cpuCoolerList.Add(
            cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM4", "AM5", "FM1", "FM2", "FM2+", "LGA 1150", "LGA 1151", "LGA 1151-v2", "LGA 1155", "LGA 1200", "LGA 1700" })
                .WithMaxTdp(180)
                .WithFormFactor(new FormFactor(129, 158, 103))
                .Build());
        cpuCoolerList.Add(
            cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1151-v2", "LGA 1156", "LGA 1200", "LGA 1700" })
                .WithMaxTdp(120)
                .WithFormFactor(new FormFactor(121, 136, 76))
                .Build());
        cpuCoolerList.Add(
            cpuCoolerBuilder.WithSupportedSocketsList(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700" })
                .WithMaxTdp(200)
                .WithFormFactor(new FormFactor(125, 155, 96))
                .Build());
    }

    public static void VideocardInitializer(IList<IVideocard> videocardList)
    {
        IVideocardBuilder videocardBuilder = new VideocardBuilder();

        videocardList.Add(
            videocardBuilder.WithVideoCardMemorySize(8)
                .WithPcieVersion(4)
                .WithGpuFrequency(1410)
                .WithPowerConsumption(256)
                .WithFormFactor(new FormFactor(118, 53, 294))
                .Build());
        videocardList.Add(
            videocardBuilder.WithVideoCardMemorySize(4)
                .WithPcieVersion(3)
                .WithGpuFrequency(1410)
                .WithPowerConsumption(90)
                .WithFormFactor(new FormFactor(111, 33, 200))
                .Build());
        videocardList.Add(
            videocardBuilder.WithVideoCardMemorySize(12)
                .WithPcieVersion(4)
                .WithGpuFrequency(2310)
                .WithPowerConsumption(285)
                .WithFormFactor(new FormFactor(133, 64, 329))
                .Build());
        videocardList.Add(
            videocardBuilder.WithVideoCardMemorySize(8)
                .WithPcieVersion(4)
                .WithGpuFrequency(2310)
                .WithPowerConsumption(160)
                .WithFormFactor(new FormFactor(124, 41, 250))
                .Build());
        videocardList.Add(
            videocardBuilder.WithVideoCardMemorySize(24)
                .WithPcieVersion(4)
                .WithGpuFrequency(2230)
                .WithPowerConsumption(450)
                .WithFormFactor(new FormFactor(136, 62, 322))
                .Build());
    }

    public static void SsdInitializer(IList<ISsd> ssdList)
    {
        ISsdBuilder ssdBuilder = new SsdBuilder();

        ssdList.Add(
            ssdBuilder.WithConnectionOption("SATA")
                .WithMemorySize(1000)
                .WithMaxOperatingSpeed(560)
                .WithPowerConsumption(4)
                .Build());
        ssdList.Add(
            ssdBuilder.WithConnectionOption("SATA")
                .WithMemorySize(240)
                .WithMaxOperatingSpeed(520)
                .WithPowerConsumption(2)
                .Build());
        ssdList.Add(
            ssdBuilder.WithConnectionOption("SATA")
                .WithMemorySize(960)
                .WithMaxOperatingSpeed(550)
                .WithPowerConsumption(4)
                .Build());
        ssdList.Add(
            ssdBuilder.WithConnectionOption("PCI-E")
                .WithMemorySize(500)
                .WithMaxOperatingSpeed(3500)
                .WithPowerConsumption(9)
                .Build());
        ssdList.Add(
            ssdBuilder.WithConnectionOption("PCI-E")
                .WithMemorySize(1024)
                .WithMaxOperatingSpeed(7000)
                .WithPowerConsumption(6)
                .Build());
    }

    public static void HddInitializer(IList<IHdd> hddList)
    {
        IHddBuilder hddBuilder = new HddBuilder();

        hddList.Add(
            hddBuilder.WithMemorySize(2000)
                .WithSpindleRotationSpeed(7200)
                .WithPowerConsumption(4)
                .Build());
        hddList.Add(
            hddBuilder.WithMemorySize(4000)
                .WithSpindleRotationSpeed(5400)
                .WithPowerConsumption(5)
                .Build());
        hddList.Add(
            hddBuilder.WithMemorySize(1000)
                .WithSpindleRotationSpeed(7200)
                .WithPowerConsumption(7)
                .Build());
        hddList.Add(
            hddBuilder.WithMemorySize(6000)
                .WithSpindleRotationSpeed(5400)
                .WithPowerConsumption(5)
                .Build());
        hddList.Add(
            hddBuilder.WithMemorySize(18000)
                .WithSpindleRotationSpeed(7200)
                .WithPowerConsumption(8)
                .Build());
    }

    public static void PcCasesInitializer(IList<IPcCase> pcCaseList)
    {
        IPcCaseBuilder pcCaseBuilder = new PcCaseBuilder();

        pcCaseList.Add(
            pcCaseBuilder.WithFormFactor(new FormFactor(260, 496, 465))
                .WithMaxVideoCardFormFactor(new FormFactor(140, 70, 390))
                .WithSupportedMotherboardFormFactor(new FormFactor(250, 50, 310))
                .Build());
        pcCaseList.Add(
            pcCaseBuilder.WithFormFactor(new FormFactor(310, 523, 526))
                .WithMaxVideoCardFormFactor(new FormFactor(207, 94, 435))
                .WithSupportedMotherboardFormFactor(new FormFactor(308, 57, 255))
                .Build());
        pcCaseList.Add(
            pcCaseBuilder.WithFormFactor(new FormFactor(157, 360, 360))
                .WithMaxVideoCardFormFactor(new FormFactor(105, 64, 300))
                .WithSupportedMotherboardFormFactor(new FormFactor(203, 48, 179))
                .Build());
        pcCaseList.Add(
            pcCaseBuilder.WithFormFactor(new FormFactor(204, 479, 445))
                .WithMaxVideoCardFormFactor(new FormFactor(205, 87, 360))
                .WithSupportedMotherboardFormFactor(new FormFactor(289, 68, 311))
                .Build());
        pcCaseList.Add(
            pcCaseBuilder.WithFormFactor(new FormFactor(238, 523, 526))
                .WithMaxVideoCardFormFactor(new FormFactor(211, 92, 435))
                .WithSupportedMotherboardFormFactor(new FormFactor(313, 78, 255))
                .Build());
    }

    public static void PowerSupplyUnitInitializer(IList<IPowerSupplyUnit> powerSupplyUnitList)
    {
        IPowerSupplyUnitBuilder powerSupplyUnitBuilder = new PowerSupplyUnitBuilder();

        powerSupplyUnitList.Add(
        powerSupplyUnitBuilder.WithPeakPower(400)
            .Build());
        powerSupplyUnitList.Add(
            powerSupplyUnitBuilder.WithPeakPower(600)
                .Build());
        powerSupplyUnitList.Add(
            powerSupplyUnitBuilder.WithPeakPower(800)
                .Build());
        powerSupplyUnitList.Add(
            powerSupplyUnitBuilder.WithPeakPower(900)
                .Build());
        powerSupplyUnitList.Add(
            powerSupplyUnitBuilder.WithPeakPower(1000)
                .Build());
    }

    public static void RamInitializer(IList<IRam> ramList, IList<Xmp> xmpList)
    {
        IRamBuilder ramBuilder = new RamBuilder();

        ramList.Add(
            ramBuilder.WithMemorySize(16)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(1066, 1.2), new RamMemoryFrequencyAndVoltage(2066, 1.25), new RamMemoryFrequencyAndVoltage(3066, 1.3) })
                .WithFormFactor(new FormFactor(6, 34, 150))
                .WithDdrStandard("DDR4")
                .WithPowerConsumption(1.35)
                .WithSupportedXmpProfile(xmpList[0])
                .Build());
        ramList.Add(
            ramBuilder.WithMemorySize(16)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(2066, 1.25), new RamMemoryFrequencyAndVoltage(3066, 1.3) })
                .WithFormFactor(new FormFactor(6, 35, 150))
                .WithDdrStandard("DDR5")
                .WithPowerConsumption(1.25)
                .WithSupportedXmpProfile(xmpList[2])
                .Build());
        ramList.Add(
            ramBuilder.WithMemorySize(16)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(1066, 1.2), new RamMemoryFrequencyAndVoltage(2066, 1.25) })
                .WithFormFactor(new FormFactor(6, 34, 150))
                .WithDdrStandard("DDR4")
                .WithPowerConsumption(1.45)
                .WithSupportedXmpProfile(xmpList[2])
                .Build());
        ramList.Add(
            ramBuilder.WithMemorySize(8)
                .WithMemoryFrequencyList(new List<RamMemoryFrequencyAndVoltage>() { new RamMemoryFrequencyAndVoltage(1066, 1.2) })
                .WithFormFactor(new FormFactor(6, 30, 150))
                .WithDdrStandard("DDR3")
                .WithPowerConsumption(1.1)
                .WithSupportedXmpProfile(xmpList[2])
                .Build());
    }

    public static void WiFiAdapterInitializer(IList<IWiFiAdapter> wiFiAdapterList)
    {
        IWiFiAdapterBuilder wiFiAdapterBuilder = new WiFiAdapterBuilder();

        wiFiAdapterList.Add(
            wiFiAdapterBuilder.WithWiFiStandardVersion("802.11ac")
                .WithPcieVersion(4)
                .WithIsBluetoothModule(true)
                .WithPowerConsumption(5)
                .Build());
        wiFiAdapterList.Add(
            wiFiAdapterBuilder.WithWiFiStandardVersion("802.11ax")
                .WithPcieVersion(4)
                .WithIsBluetoothModule(true)
                .WithPowerConsumption(8)
                .Build());
        wiFiAdapterList.Add(
            wiFiAdapterBuilder.WithWiFiStandardVersion("802.11n")
                .WithPcieVersion(4)
                .WithIsBluetoothModule(false)
                .WithPowerConsumption(5)
                .Build());
        wiFiAdapterList.Add(
            wiFiAdapterBuilder.WithWiFiStandardVersion("802.11n")
                .WithPcieVersion(3)
                .WithIsBluetoothModule(false)
                .WithPowerConsumption(4)
                .Build());
    }
}