using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public interface IPcCaseBuilder
{
    IPcCaseBuilder WithMaxVideoCardFormFactor(FormFactor? maxVideoCardFactor);

    IPcCaseBuilder WithSupportedMotherboardFormFactorList(IList<FormFactor> supportedMotherboardFormFactorList);

    IPcCaseBuilder WithFormFactor(FormFactor? formFactor);

    void DeBuild(IPcCase pcCase);
    IPcCase Build();
}