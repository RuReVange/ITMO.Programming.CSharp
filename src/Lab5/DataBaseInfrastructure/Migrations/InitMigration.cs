using Npgsql;

namespace DataBaseInfrastructure.Migrations;

public static class InitMigration
{
    public static void Up()
    {
        string commandString =
            @"
            create table RegularUsers
            (
                Id serial, 
                Password text not null ,
                AccountBalance bigint not null default 0,
                PRIMARY KEY(Id)
            );

            create table AdminUsers
            (
                Id serial, 
                SystemPassword text not null ,
                PRIMARY KEY(Id)
            );
            
            create table Logs
            (
                LogId serial,
                UserId bigint not null,
                UserType text not null,
                Message text not null,
                PRIMARY KEY(LogId)
            );
            insert into AdminUsers (SystemPassword) values ('password');
            ";

        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.ExecuteNonQuery();
        transaction.Commit();
        connection.Close();
    }

    public static void Down()
    {
        string commandString =
            @"
            drop table RegularUsers;
            drop table AdminUsers;
            drop table Logs;
            ";

        using NpgsqlConnection connection = DataSourceConnection.Connect();
        connection.Open();
        using NpgsqlTransaction transaction = connection.BeginTransaction();
        using var command = new NpgsqlCommand(commandString, connection);
        command.ExecuteNonQuery();
        transaction.Commit();
        connection.Close();
    }
}