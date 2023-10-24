using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuCoolerDirectory;

public class CpuCooler : ICpuCooler
{
    public CpuCooler(IList<string>? supportedSocketsList, int maxTdp, FormFactor? formFactor)
    {
        SupportedSocketsList = supportedSocketsList;
        MaxTdp = maxTdp;
        FormFactor = formFactor;
    }

    public IList<string>? SupportedSocketsList { get; init; }
    public int MaxTdp { get; init; }
    public FormFactor? FormFactor { get; init; }
}