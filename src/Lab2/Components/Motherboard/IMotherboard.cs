using Itmo.ObjectOrientedProgramming.Lab2.Components.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components.Motherboard;

public interface IMotherboard
{
    public string Socket { get; init; }
    public int PcieLineQty { get; init; }
    public int SataPortQty { get; init; }

    // чипсет
    public string SupportedDdrStandard { get; init; }
    public int RamSlots { get; init; }
    public FormFactor FormFactor { get; init; }
    public IBios Bios { get; init; }
}