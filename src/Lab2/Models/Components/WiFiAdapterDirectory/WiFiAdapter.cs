namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.WiFiAdapterDirectory;

public class WiFiAdapter : IWiFiAdapter
{
    public WiFiAdapter(string? wiFiStandardVersion, bool isBluetoothModule, int pcieVersion, int powerConsumption)
    {
        ComponentType = "WiFiAdapter";
        WiFiStandardVersion = wiFiStandardVersion;
        IsBluetoothModule = isBluetoothModule;
        PcieVersion = pcieVersion;
        PowerConsumption = powerConsumption;
    }

    public string ComponentType { get; init; }
    public string? WiFiStandardVersion { get; init; }
    public bool IsBluetoothModule { get; init; }
    public int PcieVersion { get; init; } // 1.0, 2.0, 3.0 и 4.0
    public int PowerConsumption { get; init; } // ватт
}