// See https://aka.ms/new-console-template for more information

using ApplicationCore.Models.DomainModels;
using DataBaseInfrastructure.Migrations;
using ParserInfrastructure.Parser;

InitMigration.Down();
InitMigration.Up();

while (true)
{
    Console.WriteLine("Write the command, please");
    string parsingString = Console.ReadLine();
    if (parsingString == "exit")
    {
        System.Environment.Exit(0);
    }

    var commandContext = new CommandContext();
    if (parsingString != null)
        CommandParser.Parse(commandContext, parsingString);

    IParser parser = new StartParser();
    parser.Parse(commandContext);
}

// commands syntax:
// For all:
// exit

// For Admin:
// login -m admin -p "password"
// add regular user -p "password"
// change system password -p "newPassword"
// show log history -m admin -i "id"
// logout -m admin

// For User:
// login -m user -i "id" -p "password"
// show account balance
// withdraw money -b "balance"
// refill account -b "balance"
// show log history -m user
// logout -m user

// Для проги:
// login -m admin -p password
// add regular user -p zayac1
// change system password -p newPassword
// show log history -m admin -i 1
// logout -m admin
// add regular user -p kit
// login -m user -i 1 -p zayac1
// show account balance
// withdraw money -b 100
// refill account -b 250
// refill account -b 200
// show log history -m user
// logout -m user
// exit