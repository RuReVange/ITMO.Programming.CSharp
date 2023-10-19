namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class Motherboard
{
    public Motherboard(string? socket, int pcieLineQty, int sataPortQty, string? supportedDdrStandard, int ramSlots, FormFactor? formFactor, Bios? bios)
    {
        Socket = socket;
        PcieLineQty = pcieLineQty;
        SataPortQty = sataPortQty;
        SupportedDdrStandard = supportedDdrStandard;
        RamSlots = ramSlots;
        FormFactor = formFactor;
        Bios = bios;
    }

    public string? Socket { get; init; }
    public int PcieLineQty { get; init; }
    public int SataPortQty { get; init; }

    // чипсет
    public string? SupportedDdrStandard { get; init; }
    public int RamSlots { get; init; }
    public FormFactor? FormFactor { get; init; }
    public Bios? Bios { get; init; }
}