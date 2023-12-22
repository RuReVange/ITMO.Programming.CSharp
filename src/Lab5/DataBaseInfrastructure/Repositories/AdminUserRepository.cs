using Abstractions.Repositories;
using ApplicationCore.Models.DomainModels;
using DataBaseInfrastructure.Migrations;
using Npgsql;

namespace DataBaseInfrastructure.Repositories;

public class AdminUserRepository : IAdminUserRepository
{
    public AdminUser? FindAdminUser(string systemPassword)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select * from AdminUsers where SystemPassword = (@systemPassword)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("systemPassword", systemPassword));
        NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            reader.Close();
            transaction.Commit();
            connection.Close();
            return null;
        }
        else
        {
            var tmpAdminUser = new AdminUser(reader.GetInt32(0), reader.GetString(1));
            reader.Close();

            transaction.Commit();
            connection.Close();
            return tmpAdminUser;
        }
    }

    public bool AddRegularUser(string password, AdminUser adminUser)
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
        command.Parameters.Add(new NpgsqlParameter("UserId", adminUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", adminUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"RegularUser with ID:{tmpIdRegularUser} was created"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return true;
    }

    public bool ChangeSystemPassword(string newPassword, AdminUser adminUser)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"update AdminUsers set SystemPassword = (@password) where id = (@adminUserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("password", newPassword));
        command.Parameters.Add(new NpgsqlParameter("adminUserId", adminUser.Id));
        command.ExecuteNonQuery();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", adminUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", adminUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"AdminUser's(ID:{adminUser.Id}) SystemPassword was changed"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return true;
    }

    public RegularUser? FindRegularUser(int id, AdminUser adminUser)
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
        command.Parameters.Add(new NpgsqlParameter("UserId", adminUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", adminUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"AdminUser with ID:{adminUser.Id} tried to find a RegularUser with an ID:{tmpRegularUser.Id}"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return tmpRegularUser;
    }

    public IList<Log> ShowLogHistory(int id)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select * from Logs where UserId = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", id));
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