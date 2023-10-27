using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public class PcCase : IPcCase
{
    public PcCase(FormFactor? maxVideoCardFormFactor, FormFactor? supportedMotherboardFormFactor, FormFactor? formFactor)
    {
        ComponentType = "PcCase";
        MaxVideoCardFormFactor = maxVideoCardFormFactor;
        SupportedMotherboardFormFactor = supportedMotherboardFormFactor;
        FormFactor = formFactor;
    }

    public string ComponentType { get; init; }
    public FormFactor? MaxVideoCardFormFactor { get; init; }
    public FormFactor? SupportedMotherboardFormFactor { get; init; }
    public FormFactor? FormFactor { get; init; }
}