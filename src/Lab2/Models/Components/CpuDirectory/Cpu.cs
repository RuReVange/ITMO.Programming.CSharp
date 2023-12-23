using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.CpuDirectory;

public class Cpu : ICpu
{
        public Cpu(float coreFrequency, int coreQty, string? socket, bool videoCore, IList<int> supportedMemoryFrequencyList, int tdp, int powerConsumption)
        {
                ComponentType = "Cpu";
                CoreFrequency = coreFrequency;
                CoreQty = coreQty;
                Socket = socket;
                VideoCore = videoCore;
                SupportedMemoryFrequencyList = supportedMemoryFrequencyList;
                Tdp = tdp;
                PowerConsumption = powerConsumption;
        }

        public string ComponentType { get; init; }
        public float CoreFrequency { get; init; }
        public int CoreQty { get; init; }
        public string? Socket { get; init; }
        public bool VideoCore { get; init; }
        public IList<int> SupportedMemoryFrequencyList { get; init; } // МГц
        public int Tdp { get; init; }
        public int PowerConsumption { get; init; }
}