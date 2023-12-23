using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

public class Chipset
{
    public Chipset(bool xmpSupport, IList<int>? suportedMemoryFrequencyList)
    {
        XmpSupport = xmpSupport;
        SuportedMemoryFrequencyList = suportedMemoryFrequencyList;
    }

    public bool XmpSupport { get; init; }
    public IList<int>? SuportedMemoryFrequencyList { get; init; }
}