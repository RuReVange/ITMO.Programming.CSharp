using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components.CpuCooler;

public interface ICpuCooler
{
    public FormFactor FormFactor { get; init; }
    public IList<string> SupportedSocketsList { get; init; }
    public int MaxTdp { get; init; }
}