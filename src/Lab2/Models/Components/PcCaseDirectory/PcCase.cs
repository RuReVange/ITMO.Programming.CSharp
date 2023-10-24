using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public class PcCase : IPcCase
{
    public PcCase(FormFactor? maxVideoCardFormFactor, IList<FormFactor>? supportedMotherboardFormFactorList, FormFactor? formFactor)
    {
        MaxVideoCardFormFactor = maxVideoCardFormFactor;
        SupportedMotherboardFormFactorList = supportedMotherboardFormFactorList;
        FormFactor = formFactor;
    }

    public FormFactor? MaxVideoCardFormFactor { get; init; }
    public IList<FormFactor>? SupportedMotherboardFormFactorList { get; init; }
    public FormFactor? FormFactor { get; init; }
}