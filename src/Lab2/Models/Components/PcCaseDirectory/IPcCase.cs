using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.PcCaseDirectory;

public interface IPcCase
{
    public FormFactor? MaxVideoCardFormFactor { get; init; }
    public IList<FormFactor>? SupportedMotherboardFormFactorList { get; init; }
    public FormFactor? FormFactor { get; init; }
}