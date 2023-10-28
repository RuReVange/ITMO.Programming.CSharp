using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

public class Bios
{
    public Bios(string type, string version, IList<string>? supportedProcessorsList)
    {
        Type = type;
        Version = version;
        SupportedProcessorsList = supportedProcessorsList;
    }

    public string Type { get; init; }
    public string Version { get; init; }
    public IList<string>? SupportedProcessorsList { get; init; } // проверка на соответствие сокету. Либо соответствие стринги названию объекта процессора
}