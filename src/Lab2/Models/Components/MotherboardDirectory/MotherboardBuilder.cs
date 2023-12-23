using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.MotherboardDirectory;

public class MotherboardBuilder : IMotherboardBuilder
{
    private string? _socket;
    private int _pcieLineQty;
    private int _sataPortQty;
    private Chipset? _chipset;
    private string? _supportedDdrStandard;
    private int _ramSlots;
    private FormFactor? _formFactor;
    private Bios? _bios;

    public IMotherboardBuilder WithSocket(string? socket)
    {
        _socket = socket;
        return this;
    }

    public IMotherboardBuilder WithPcieLineQty(int pcieLineQty)
    {
        _pcieLineQty = pcieLineQty;
        return this;
    }

    public IMotherboardBuilder WithSataPortQty(int sataPortQty)
    {
        _sataPortQty = sataPortQty;
        return this;
    }

    public IMotherboardBuilder WithChipset(Chipset? chipset)
    {
        _chipset = chipset;
        return this;
    }

    public IMotherboardBuilder WithSupportedDdrStandard(string? supportedDdrStandard)
    {
        _supportedDdrStandard = supportedDdrStandard;
        return this;
    }

    public IMotherboardBuilder WithRamSlots(int ramSlots)
    {
        _ramSlots = ramSlots;
        return this;
    }

    public IMotherboardBuilder WithFormFactor(FormFactor? formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IMotherboardBuilder WithBios(Bios? bios)
    {
        _bios = bios;
        return this;
    }

    public void DeBuild(IMotherboard motherboard)
    {
        _socket = motherboard.Socket;
        _pcieLineQty = motherboard.PcieLineQty;
        _sataPortQty = motherboard.SataPortQty;
        _chipset = motherboard.Chipset;
        _supportedDdrStandard = motherboard.SupportedDdrStandard;
        _ramSlots = motherboard.RamSlots;
        _formFactor = motherboard.FormFactor;
        _bios = motherboard.Bios;
    }

    public IMotherboard Build()
    {
        return new Motherboard(
            _socket,
            _pcieLineQty,
            _sataPortQty,
            _chipset,
            _supportedDdrStandard,
            _ramSlots,
            _formFactor,
            _bios);
    }
}