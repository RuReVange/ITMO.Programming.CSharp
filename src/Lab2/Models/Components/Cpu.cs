namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public class Cpu
{
        public Cpu(int coreFrequency, int coreQty, string? socket, bool videoCore, int supportedMemoryFrequency, int tdp, int powerConsumption)
        {
                CoreFrequency = coreFrequency;
                CoreQty = coreQty;
                Socket = socket;
                VideoCore = videoCore;
                SupportedMemoryFrequency = supportedMemoryFrequency;
                Tdp = tdp;
                PowerConsumption = powerConsumption;
        }

        public int CoreFrequency { get; init; }
        public int CoreQty { get; init; }
        public string? Socket { get; init; }
        public bool VideoCore { get; init; }
        public int SupportedMemoryFrequency { get; init; }
        public int Tdp { get; init; }
        public int PowerConsumption { get; init; }
}