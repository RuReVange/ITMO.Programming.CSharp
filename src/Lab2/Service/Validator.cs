using Itmo.ObjectOrientedProgramming.Lab2.Models.PersonalComputer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.ResultType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public static class Validator
{
    public static Result Validate(IPersonalComputer? personalComputer)
    {
        var result = new Result();

        if (personalComputer is null)
        {
            result.Unsuccess();
            return result;
        }
        else
        {
            result.IsMotherboardInstalled = true;
        }

        if (personalComputer.Motherboard?.Socket == personalComputer.Cpu?.Socket &&
            personalComputer.Motherboard?.Bios?.SupportedProcessorsList?[0] == personalComputer.Cpu?.Socket)
        {
            result.IsCpuInstalled = true;
        }
        else
        {
            result.Unsuccess();
            return result;
        }

        if (personalComputer.Cpu?.Tdp < personalComputer.CpuCooler?.MaxTdp)
        {
            result.IsCpuCoolerInstalled = true;
        }
        else
        {
            result.BuildWithoutWarranty();
        }

        if (personalComputer.Ram is not null)
        {
            if (personalComputer.Motherboard?.SupportedDdrStandard is not null &&
                personalComputer.Motherboard?.SupportedDdrStandard != personalComputer.Ram.DdrStandard)
            {
                result.Unsuccess();
                return result;
            }
            else if (personalComputer.Ram?.SupportedXmpProfile is not null)
            {
                if (personalComputer.Motherboard?.Chipset?.XmpSupport == false)
                {
                    result.Unsuccess();
                    return result;
                }

                if (personalComputer.Cpu?.SupportedMemoryFrequencyList != null)
                {
                    foreach (int supportedMemoryFrequency in personalComputer.Cpu.SupportedMemoryFrequencyList)
                    {
                        if (supportedMemoryFrequency == personalComputer.Ram.SupportedXmpProfile.MemoryFrequency)
                        {
                            result.IsRamInstalled = true;
                            break;
                        }
                    }

                    if (result.IsRamInstalled == false)
                    {
                        result.Unsuccess();
                        return result;
                    }
                }
            }
            else if (personalComputer.Motherboard?.Chipset?.SuportedMemoryFrequencyList?[0] >
                     personalComputer.Ram?.MemoryFrequencyList?[0].MemoryFrequency)
            {
                result.Unsuccess();
                return result;
            }
        }

        if (personalComputer.Videocard is null && personalComputer.Cpu?.VideoCore == false)
        {
            result.Unsuccess();
            return result;
        }
        else
        {
            result.IsVideocardInstalled = true;
        }

        if (personalComputer.Ssd is null && personalComputer.Hdd is null)
        {
            result.Unsuccess();
            return result;
        }
        else
        {
            if (personalComputer.Ssd is not null)
            {
                result.IsSsdInstalled = true;
            }

            if (personalComputer.Hdd is not null)
            {
                result.IsHddInstalled = true;
            }
        }

        if (personalComputer.PcCase is not null)
        {
            if (personalComputer.Videocard?.FormFactor?.Length >
                personalComputer.PcCase.MaxVideoCardFormFactor?.Length ||
                personalComputer.Videocard?.FormFactor?.Width >
                personalComputer.PcCase.MaxVideoCardFormFactor?.Width)
            {
                result.Unsuccess();
                return result;
            }
            else if (personalComputer.Motherboard?.FormFactor?.Length > personalComputer.PcCase.FormFactor?.Length ||
                     personalComputer.Motherboard?.FormFactor?.Width > personalComputer.PcCase.FormFactor?.Width ||
                     personalComputer.Motherboard?.FormFactor?.Height + personalComputer.CpuCooler?.FormFactor?.Height >
                     personalComputer.PcCase.FormFactor?.Height)
            {
                result.Unsuccess();
                return result;
            }

            result.IsPcCaseInstalled = true;
        }
        else
        {
            result.Unsuccess();
            return result;
        }

        if (personalComputer.PowerSupplyUnit is not null)
        {
            double? powerConsumptionSum =
                personalComputer.Cpu?.PowerConsumption +
                personalComputer.Ram?.PowerConsumption +
                personalComputer.Videocard?.PowerConsumption +
                personalComputer.Ssd?.PowerConsumption +
                personalComputer.Hdd?.PowerConsumption +
                personalComputer.WiFiAdapter?.PowerConsumption;

            switch ((int?)powerConsumptionSum - personalComputer.PowerSupplyUnit.PeakPower)
            {
                case > 100:
                    result.Unsuccess();
                    return result;
                case > 0:
                    result.BuildWithoutWarranty();
                    result.IsPowerSupplyUnitInstalled = true;
                    break;
                default:
                    result.IsPowerSupplyUnitInstalled = true;
                    break;
            }
        }
        else
        {
            result.Unsuccess();
            return result;
        }

        return result;
    }
}