namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ResultType;

public class Result
{
    public Result()
    {
        Success();
    }

    public string? FinalResult { get; private set; }
    public bool IsMotherboardInstalled { get; internal set; }
    public bool IsCpuInstalled { get; internal set; }
    public bool IsCpuCoolerInstalled { get; internal set; }
    public bool IsRamInstalled { get; internal set; }
    public bool IsVideocardInstalled { get; internal set; }
    public bool IsSsdInstalled { get; internal set; }
    public bool IsHddInstalled { get; internal set; }
    public bool IsPcCaseInstalled { get; internal set; }
    public bool IsPowerSupplyUnitInstalled { get; internal set; }
    public bool IsWiFiAdapterInstalled { get; internal set; } = true;

    public void Success()
    {
        FinalResult = "Successful build";
    }

    public void BuildWithoutWarranty()
    {
        FinalResult = "Warranty obligations are denied. Some components may be unstable";
    }

    public void Unsuccess()
    {
        FinalResult = "Invalid build. The components are incompatible";
    }
}