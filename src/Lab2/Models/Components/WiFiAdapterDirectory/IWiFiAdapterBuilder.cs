namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.WiFiAdapterDirectory;

public interface IWiFiAdapterBuilder
{
    IWiFiAdapterBuilder WithWiFiStandardVersion(int wiFiStandardVersion);
    IWiFiAdapterBuilder WithIsBluetoothModule(bool isBluetoothModule);
    IWiFiAdapterBuilder WithPcieVersion(int pcieVersion);
    IWiFiAdapterBuilder WithPowerConsumption(int powerConsumption);

    void DeBuild(IWiFiAdapter wiFiAdapter);
    IWiFiAdapter Build();
}