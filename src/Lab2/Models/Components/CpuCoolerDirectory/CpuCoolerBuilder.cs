using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuCoolerDirectory;

public class CpuCoolerBuilder : ICpuCoolerBuilder
{
    private IList<string> _supportedSocketsList;
    private int _maxTdp;
    private FormFactor? _formFactor;

    public CpuCoolerBuilder()
    {
        _supportedSocketsList = new List<string>();
    }

    public ICpuCoolerBuilder WithSupportedSocketsList(IList<string> supportedSocketsList)
    {
        foreach (string supportedSockets in supportedSocketsList)
        {
            _supportedSocketsList.Add(supportedSockets);
        }

        return this;
    }

    public ICpuCoolerBuilder WithMaxTdp(int maxTdp)
    {
        _maxTdp = maxTdp;
        return this;
    }

    public ICpuCoolerBuilder WithFormFactor(FormFactor? formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public void DeBuild(ICpuCooler cpuCooler)
    {
        _supportedSocketsList = new List<string>(cpuCooler.SupportedSocketsList ?? throw new InvalidOperationException());
        _maxTdp = cpuCooler.MaxTdp;
        _formFactor = cpuCooler.FormFactor;
    }

    public ICpuCooler Build()
    {
        return new CpuCooler(_supportedSocketsList, _maxTdp, _formFactor);
    }
}