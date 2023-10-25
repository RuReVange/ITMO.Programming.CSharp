using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public class PcCaseBuilder : IPcCaseBuilder
{
    private FormFactor? _supportedMotherboardFormFactor;
    private FormFactor? _maxVideoCardFormFactor;
    private FormFactor? _formFactor;
    public IPcCaseBuilder WithMaxVideoCardFormFactor(FormFactor? maxVideoCardFactor)
    {
        _maxVideoCardFormFactor = maxVideoCardFactor;
        return this;
    }

    public IPcCaseBuilder WithSupportedMotherboardFormFactor(FormFactor supportedMotherboardFormFactor)
    {
        _supportedMotherboardFormFactor = supportedMotherboardFormFactor;
        return this;
    }

    public IPcCaseBuilder WithFormFactor(FormFactor? formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public void DeBuild(IPcCase pcCase)
    {
        _maxVideoCardFormFactor = pcCase.MaxVideoCardFormFactor;
        _supportedMotherboardFormFactor = pcCase.SupportedMotherboardFormFactor;
        _formFactor = pcCase.FormFactor;
    }

    public IPcCase Build()
    {
        return new PcCase(_maxVideoCardFormFactor, _supportedMotherboardFormFactor, _formFactor);
    }
}