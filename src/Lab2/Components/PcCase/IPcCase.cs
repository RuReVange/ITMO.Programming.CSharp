using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components.PcCase;

public interface IPcCase
{
    public FormFactor MaxVideoCardFormFactor { get; init; }
    public IList<FormFactor> SupportedMotherboardFormFactor { get; init; }
    public FormFactor FormFactor { get; init; }
}