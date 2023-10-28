namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.WiFiAdapterDirectory;

public class WiFiAdapterBuilder : IWiFiAdapterBuilder
{
    private string? _wiFiStandardVersion;
    private bool _isBluetoothModule;
    private int _pcieVersion;
    private int _powerConsumption;

    public IWiFiAdapterBuilder WithWiFiStandardVersion(string? wiFiStandardVersion)
    {
        _wiFiStandardVersion = wiFiStandardVersion;
        return this;
    }

    public IWiFiAdapterBuilder WithIsBluetoothModule(bool isBluetoothModule)
    {
        _isBluetoothModule = isBluetoothModule;
        return this;
    }

    public IWiFiAdapterBuilder WithPcieVersion(int pcieVersion)
    {
        _pcieVersion = pcieVersion;
        return this;
    }

    public IWiFiAdapterBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public void DeBuild(IWiFiAdapter wiFiAdapter)
    {
        _wiFiStandardVersion = wiFiAdapter.WiFiStandardVersion;
        _isBluetoothModule = wiFiAdapter.IsBluetoothModule;
        _pcieVersion = wiFiAdapter.PcieVersion;
        _powerConsumption = wiFiAdapter.PowerConsumption;
    }

    public IWiFiAdapter Build()
    {
        return new WiFiAdapter(
            _wiFiStandardVersion,
            _isBluetoothModule,
            _pcieVersion,
            _powerConsumption);
    }
}