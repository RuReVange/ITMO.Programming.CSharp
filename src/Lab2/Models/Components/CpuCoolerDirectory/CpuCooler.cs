using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuCoolerDirectory;

public class CpuCooler : ICpuCooler
{
    public CpuCooler(IList<string>? supportedSocketsList, int maxTdp, FormFactor? formFactor)
    {
        ComponentType = "CpuCooler";
        SupportedSocketsList = supportedSocketsList;
        MaxTdp = maxTdp;
        FormFactor = formFactor;
    }

    public string ComponentType { get; init; }
    public IList<string>? SupportedSocketsList { get; init; }
    public int MaxTdp { get; init; }
    public FormFactor? FormFactor { get; init; }
}