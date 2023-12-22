using Abstractions.Repositories;
using ApplicationCore.DomainModels;
using DataBaseInfrastructure.Migrations;
using Npgsql;

namespace DataBaseInfrastructure.Repositories;

public class RegularUserRepository : IRegularUserRepository
{
    public RegularUser? FindRegularUser(RegularUser regularUser)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select * from RegularUsers where id = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
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
            var tmpRegularUser = new RegularUser(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            reader.Close();

            transaction.Commit();
            connection.Close();
            return tmpRegularUser;
        }
    }

    public int ShowAccountBalance(RegularUser regularUser)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select AccountBalance from RegularUsers where id = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        NpgsqlDataReader reader = command.ExecuteReader();
        reader.Read();
        int accountBalance = reader.GetInt32(0);
        reader.Close();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", regularUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"RegularUser with ID:{regularUser.Id} has reviewed his balance"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return accountBalance;
    }

    public bool WithdrawMoney(int moneyAmount, RegularUser regularUser)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select AccountBalance from RegularUsers where id = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        NpgsqlDataReader reader = command.ExecuteReader();
        reader.Read();
        int accountBalance = reader.GetInt32(0);
        reader.Close();

        accountBalance -= moneyAmount;
        commandString = @"update RegularUsers set AccountBalance = (@newAccountBalance) where id = (@UserId)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("newAccountBalance", accountBalance));
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        command.ExecuteNonQuery();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", regularUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"RegularUser with ID:{regularUser.Id} has withdrawn money from the account"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return true;
    }

    public bool RefillAccount(int moneyAmount, RegularUser regularUser)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select AccountBalance from RegularUsers where id = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        NpgsqlDataReader reader = command.ExecuteReader();
        reader.Read();
        int accountBalance = reader.GetInt32(0);
        reader.Close();

        accountBalance += moneyAmount;
        commandString = @"update RegularUsers set AccountBalance = (@newAccountBalance) where id = (@UserId)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("newAccountBalance", accountBalance));
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        command.ExecuteNonQuery();

        commandString = @"insert into Logs (UserId, UserType, Message) VALUES (@UserId, @UserType, @Message)";
        command.CommandText = commandString;
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
        command.Parameters.Add(new NpgsqlParameter("UserType", regularUser.ToString()));
        command.Parameters.Add(new NpgsqlParameter("Message", $"RegularUser with ID:{regularUser.Id} has withdrawn money from the account"));
        command.ExecuteNonQuery();

        transaction.Commit();
        connection.Close();
        return true;
    }

    public IList<Log> ShowLogHistory(RegularUser regularUser)
    {
        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();

        string commandString = @"select * from Logs where UserId = (@UserId)";
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.Parameters.Add(new NpgsqlParameter("UserId", regularUser.Id));
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