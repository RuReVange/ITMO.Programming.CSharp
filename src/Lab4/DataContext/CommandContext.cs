using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.DataContext;

public class CommandContext
{
    public string? CommandNameAndAtributes { get; internal set; }
    public Dictionary<string, string>? FlagDictionary { get; internal set; }

    public void Parse(string parsingString)
    {
        if (parsingString != null && parsingString.Contains('-', StringComparison.OrdinalIgnoreCase))
        {
            string[] flags = parsingString.Substring(parsingString.IndexOf('-', StringComparison.OrdinalIgnoreCase))
                .Trim().Split(' ');
            if (flags.Length > 1)
            {
                FlagDictionary = new Dictionary<string, string>();
                for (int i = 0; i < flags.Length; i += 2)
                {
                    FlagDictionary.Add(flags[i], flags[i + 1]);
                }
            }

            CommandNameAndAtributes =
                parsingString.Substring(0, parsingString.IndexOf('-', StringComparison.OrdinalIgnoreCase) - 1).Trim();
        }
        else
        {
            CommandNameAndAtributes = parsingString?.Trim();
        }
    }
}