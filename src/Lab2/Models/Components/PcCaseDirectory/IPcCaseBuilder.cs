using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public interface IPcCaseBuilder
{
    IPcCaseBuilder WithMaxVideoCardFormFactor(FormFactor? maxVideoCardFactor);

    IPcCaseBuilder WithSupportedMotherboardFormFactor(FormFactor supportedMotherboardFormFactor);

    IPcCaseBuilder WithFormFactor(FormFactor? formFactor);

    void DeBuild(IPcCase pcCase);
    IPcCase Build();
}