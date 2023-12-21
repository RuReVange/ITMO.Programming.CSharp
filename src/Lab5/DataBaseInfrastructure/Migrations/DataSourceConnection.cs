using Npgsql;

namespace DataBaseInfrastructure.Migrations;

public static class DataSourceConnection
{
    public static NpgsqlConnection Connect()
    {
        return new NpgsqlConnection("Host=localhost;Port=6432;Username=postgres;Password=postgres;Database=postgres;");
    }
}