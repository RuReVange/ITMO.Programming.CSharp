using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class PcCase
{
    public PcCase(FormFactor? maxVideoCardFormFactor, IList<FormFactor>? supportedMotherboardFormFactor, FormFactor? formFactor)
    {
        MaxVideoCardFormFactor = maxVideoCardFormFactor;
        SupportedMotherboardFormFactor = supportedMotherboardFormFactor;
        FormFactor = formFactor;
    }

    public FormFactor? MaxVideoCardFormFactor { get; init; }
    public IList<FormFactor>? SupportedMotherboardFormFactor { get; init; }
    public FormFactor? FormFactor { get; init; }
}