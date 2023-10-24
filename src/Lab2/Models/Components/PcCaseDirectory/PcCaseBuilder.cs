using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public class PcCaseBuilder : IPcCaseBuilder
{
    private IList<FormFactor> _supportedMotherboardFormFactorList;
    private FormFactor? _maxVideoCardFormFactor;
    private FormFactor? _formFactor;

    public PcCaseBuilder()
    {
        _supportedMotherboardFormFactorList = new List<FormFactor>();
    }

    public IPcCaseBuilder WithMaxVideoCardFormFactor(FormFactor? maxVideoCardFactor)
    {
        _maxVideoCardFormFactor = maxVideoCardFactor;
        return this;
    }

    public IPcCaseBuilder WithSupportedMotherboardFormFactorList(IList<FormFactor> supportedMotherboardFormFactorList)
    {
        foreach (FormFactor formFactor in supportedMotherboardFormFactorList)
        {
            _supportedMotherboardFormFactorList.Add(formFactor);
        }

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
        _supportedMotherboardFormFactorList = new List<FormFactor>(pcCase.SupportedMotherboardFormFactorList ?? throw new InvalidOperationException());
        _formFactor = pcCase.FormFactor;
    }

    public IPcCase Build()
    {
        return new PcCase(_maxVideoCardFormFactor, _supportedMotherboardFormFactorList, _formFactor);
    }
}