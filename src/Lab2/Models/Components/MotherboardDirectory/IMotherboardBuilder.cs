using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.MotherboardDirectory;

public interface IMotherboardBuilder
{
    IMotherboardBuilder WithSocket(string? socket);

    IMotherboardBuilder WithPcieLineQty(int pcieLineQty);

    IMotherboardBuilder WithSataPortQty(int sataPortQty);

    IMotherboardBuilder WithChipset(Chipset? chipset);

    IMotherboardBuilder WithSupportedDdrStandard(string? supportedDdrStandard);

    IMotherboardBuilder WithRamSlots(int ramSlots);

    IMotherboardBuilder WithFormFactor(FormFactor? formFactor);

    IMotherboardBuilder WithBios(Bios? bios);

    void DeBuild(IMotherboard motherboard);
    IMotherboard Build();
}