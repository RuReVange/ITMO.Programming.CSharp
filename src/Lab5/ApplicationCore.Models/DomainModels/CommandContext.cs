namespace ApplicationCore.Models.DomainModels;

public class CommandContext
{
    public int ResultValue { get; set; }
    public string? CommandNameAndAtributes { get; set; }
    #pragma warning disable CA2227
    public Dictionary<string, string>? FlagDictionary { get; set; }
    #pragma warning restore CA2227
}