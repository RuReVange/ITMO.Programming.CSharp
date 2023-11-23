using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuDirectory;

public class CpuBuilder : ICpuBuilder
{
    private IList<int> _supportedMemoryFrequencyList;
    private float _coreFrequency;
    private int _coreQty;
    private string? _socket;
    private bool _videocore;
    private int _tdp;
    private int _powerConsumption;

    public CpuBuilder()
    {
        _supportedMemoryFrequencyList = new List<int>();
    }

    public ICpuBuilder WithCoreFrequency(float coreFrequency)
    {
        _coreFrequency = coreFrequency;
        return this;
    }

    public ICpuBuilder WithCoreQty(int coreQty)
    {
        _coreQty = coreQty;
        return this;
    }

    public ICpuBuilder WithSocket(string? socket)
    {
        _socket = socket;
        return this;
    }

    public ICpuBuilder WithVideoCore(bool videoCore)
    {
        _videocore = videoCore;
        return this;
    }

    public ICpuBuilder WithSupportedMemoryFrequency(IList<int> supportedMemoryFrequencyList)
    {
        foreach (int supportedMemoryFrequency in supportedMemoryFrequencyList)
        {
            _supportedMemoryFrequencyList.Add(supportedMemoryFrequency);
        }

        return this;
    }

    public ICpuBuilder WithTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public ICpuBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public void DeBuild(ICpu cpu)
    {
        _coreFrequency = cpu.CoreFrequency;
        _coreQty = cpu.CoreQty;
        _socket = cpu.Socket;
        _videocore = cpu.VideoCore;
        _supportedMemoryFrequencyList = new List<int>(cpu.SupportedMemoryFrequencyList);
        _tdp = cpu.Tdp;
        _powerConsumption = cpu.PowerConsumption;
    }

    public ICpu Build()
    {
        return new Cpu(_coreFrequency, _coreQty, _socket, _videocore, _supportedMemoryFrequencyList, _tdp, _powerConsumption);
    }
}