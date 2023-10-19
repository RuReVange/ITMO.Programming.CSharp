using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class CpuCooler
{
    public CpuCooler(FormFactor? formFactor, IList<string>? supportedSocketsList, int maxTdp)
    {
        FormFactor = formFactor;
        SupportedSocketsList = supportedSocketsList;
        MaxTdp = maxTdp;
    }

    public FormFactor? FormFactor { get; init; }
    public IList<string>? SupportedSocketsList { get; init; }
    public int MaxTdp { get; init; }
}