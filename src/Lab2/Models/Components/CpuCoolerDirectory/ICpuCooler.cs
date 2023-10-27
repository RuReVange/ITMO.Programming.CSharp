using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuCoolerDirectory;

public interface ICpuCooler : IComponent
{
    public IList<string>? SupportedSocketsList { get; init; }
    public int MaxTdp { get; init; }
    public FormFactor? FormFactor { get; init; }
}