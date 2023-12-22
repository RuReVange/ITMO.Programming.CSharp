namespace ParserInfrastructure.DataContext;

public class CommandContext
{
    public int ResultValue { get; set; }
    public string? CommandNameAndAtributes { get; internal set; }
    public Dictionary<string, string>? FlagDictionary { get; internal set; }
}