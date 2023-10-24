namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.WiFiAdapterDirectory;

public interface IWiFiAdapter
{
    public int WiFiStandardVersion { get; init; }
    public bool IsBluetoothModule { get; init; }
    public int PcieVersion { get; init; } // 1.0, 2.0, 3.0 и 4.0
    public int PowerConsumption { get; init; } // ватт
}