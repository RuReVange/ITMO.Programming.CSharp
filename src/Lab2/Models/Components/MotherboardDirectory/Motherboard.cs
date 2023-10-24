using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.MotherboardDirectory;

public class Motherboard : IMotherboard
{
    public Motherboard(
        string? socket,
        int pcieLineQty,
        int sataPortQty,
        Chipset? chipset,
        string? supportedDdrStandard,
        int ramSlots,
        FormFactor? formFactor,
        Bios? bios)
    {
        Socket = socket;
        PcieLineQty = pcieLineQty;
        SataPortQty = sataPortQty;
        Chipset = chipset;
        SupportedDdrStandard = supportedDdrStandard;
        RamSlots = ramSlots;
        FormFactor = formFactor;
        Bios = bios;
    }

    public string? Socket { get; init; }
    public int PcieLineQty { get; init; }
    public int SataPortQty { get; init; }
    public Chipset? Chipset { get; init; }
    public string? SupportedDdrStandard { get; init; }
    public int RamSlots { get; init; }
    public FormFactor? FormFactor { get; init; }
    public Bios? Bios { get; init; }
}