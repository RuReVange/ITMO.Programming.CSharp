namespace ParserInfrastructure.Parser;

public static class Context
{
    public static Dictionary<string, IParser> FirstLevelDictionary { get; private set; }
        = new Dictionary<string, IParser>()
        {
            { "login", new LoginParser() },
            { "add regular user", new AddRegularUserParser() },
            { "change system password", new ChangeSystemPasswordParser() },
            { "show log history", new ShowLogHistoryParser() },
            { "show account balance", new ShowAccountBalanceParser() },
            { "withdraw money", new WithdrawMoneyParser() },
            { "refill account", new RefillAccountParser() },
            { "logout", new LogoutParser() },
        };

    public static Dictionary<string, IParser> LoginCommandFlagsDictionary { get; private set; } =
        new Dictionary<string, IParser>() { { "-m", new LoginModeParser() } };
    public static Dictionary<string, IParser> LoginCommandModesDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "admin", new LoginAdminModeParser() }, { "user", new LoginUserModeParser() } };
    public static Dictionary<string, IParser> ShowLogHistoryFlagsDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "-m", new ShowLogHistoryModeParser() } };
    public static Dictionary<string, IParser> ShowLogHistoryCommandModesDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "admin", new ShowLogHistoryAdminModeParser() }, { "user", new ShowLogHistoryUserModeParser() } };
    public static Dictionary<string, IParser> LogoutCommandFlagsDictionary { get; private set; } =
        new Dictionary<string, IParser>() { { "-m", new LogoutModeParser() } };
    public static Dictionary<string, IParser> LogoutCommandModesDictionary { get; private set; }
        = new Dictionary<string, IParser>() { { "admin", new LogoutAdminModeParser() }, { "user", new LogoutUserModeParser() } };
}