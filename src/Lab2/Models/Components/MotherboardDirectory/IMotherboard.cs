using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.MotherboardDirectory;

public interface IMotherboard : IComponent
{
    public string? Socket { get; }
    public int PcieLineQty { get; init; }
    public int SataPortQty { get; init; }
    public Chipset? Chipset { get; init; }
    public string? SupportedDdrStandard { get; init; }
    public int RamSlots { get; init; }
    public FormFactor? FormFactor { get; init; }
    public Bios? Bios { get; init; }
}