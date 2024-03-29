using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.RamDirectory;

public class RamBuilder : IRamBuilder
{
    private IList<RamMemoryFrequencyAndVoltage> _memoryFrequencyList;
    private Xmp? _supportedXmpFrofile;
    private int _memorySize;
    private FormFactor? _formFactor;
    private string? _ddrStandard;
    private double _powerConsumption;

    public RamBuilder()
    {
        _memoryFrequencyList = new List<RamMemoryFrequencyAndVoltage>();
    }

    public IRamBuilder WithMemorySize(int memorySize)
    {
        _memorySize = memorySize;
        return this;
    }

    public IRamBuilder WithMemoryFrequencyList(IList<RamMemoryFrequencyAndVoltage> memoryFrequencyList)
    {
        foreach (RamMemoryFrequencyAndVoltage memoryFrequencyAndVoltage in memoryFrequencyList)
        {
            _memoryFrequencyList.Add(memoryFrequencyAndVoltage);
        }

        return this;
    }

    public IRamBuilder WithSupportedXmpProfile(Xmp? supportedXmpProfile)
    {
        _supportedXmpFrofile = supportedXmpProfile;
        return this;
    }

    public IRamBuilder WithFormFactor(FormFactor? formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IRamBuilder WithDdrStandard(string? ddrStandard)
    {
        _ddrStandard = ddrStandard;
        return this;
    }

    public IRamBuilder WithPowerConsumption(double powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public void DeBuild(IRam ram)
    {
        _memorySize = ram.MemorySize;
        _memoryFrequencyList = new List<RamMemoryFrequencyAndVoltage>(ram.MemoryFrequencyList ?? throw new InvalidOperationException());
        _supportedXmpFrofile = ram.SupportedXmpProfile;
        _formFactor = ram.FormFactor;
        _ddrStandard = ram.DdrStandard;
        _powerConsumption = ram.PowerConsumption;
    }

    public IRam Build()
    {
        return new Ram(
            _memorySize,
            _memoryFrequencyList,
            _supportedXmpFrofile,
            _formFactor,
            _ddrStandard,
            _powerConsumption);
    }
}