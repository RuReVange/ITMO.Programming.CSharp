using Abstractions.Repositories;
using ApplicationCore.DomainModels;
using DataBaseInfrastructure.Migrations;
using Npgsql;

namespace DataBaseInfrastructure.Repositories;

public class AdminUserRepository : IAdminUserRepository
{
    private AdminUser _adminUser;
    public AdminUserRepository(AdminUser adminUser)
    {
        _adminUser = adminUser;
    }

    public bool AddRegularUser(string password)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"insert into RegularUsers (Password) VALUES (@password) returning id";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("password", password));
        NpgsqlDataReader reader = command.ExecuteReader();
        reader.Read();
        int tmpIdRegularUser = reader.GetInt32(0);
        reader.Close();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", _adminUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", _adminUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"RegularUser with ID:{tmpIdRegularUser} was created"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return true;
    }

    public bool ChangeSystemPassword(int adminUserId, string newPassword)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"update AdminUsers set SystemPassword = (@password) where id = (@adminUserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("password", newPassword));
        command.Parameters.Add(new NpgsqlParameter("adminUserId", adminUserId));
        command.ExecuteNonQuery();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", _adminUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", _adminUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"AdminUser's(ID:{adminUserId}) SystemPassword was changed"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return true;
    }

    public RegularUser? FindRegularUser(int id)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select * from RegularUsers where id = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", id));
        NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        var tmpRegularUser = new RegularUser(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
        reader.Close();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", _adminUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", _adminUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"AdminUser with ID:{_adminUser.Id} tried to find a RegularUser with an ID:{tmpRegularUser.Id}"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return tmpRegularUser;
    }

    public IList<Log> ShowLogHistory()
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select * from Logs where UserId = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", _adminUser.Id));
        NpgsqlDataReader reader = command.ExecuteReader();

        var logList = new List<Log>();
        while (reader.Read())
        {
            var log = new Log(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
            logList.Add(log);
        }

        reader.Close();
        transaction.Commit();
        connection.Close();
        return logList;
    }
}