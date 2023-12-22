using ParserInfrastructure.DataContext;

namespace ParserInfrastructure.Parser;

public static class CommandParser
{
    public static void Parse(CommandContext commandContext, string parsingString)
    {
        if (parsingString != null && parsingString.Contains('-', StringComparison.OrdinalIgnoreCase))
        {
            string[] flags = parsingString.Substring(parsingString.IndexOf('-', StringComparison.OrdinalIgnoreCase))
                .Trim().Split(' ');
            if (flags.Length > 1)
            {
                commandContext.FlagDictionary = new Dictionary<string, string>();
                for (int i = 0; i < flags.Length; i += 2)
                {
                    commandContext.FlagDictionary.Add(flags[i], flags[i + 1]);
                }
            }

            commandContext.CommandNameAndAtributes =
                parsingString.Substring(0, parsingString.IndexOf('-', StringComparison.OrdinalIgnoreCase) - 1).Trim();
        }
        else
        {
            commandContext.CommandNameAndAtributes = parsingString?.Trim();
        }
    }
}