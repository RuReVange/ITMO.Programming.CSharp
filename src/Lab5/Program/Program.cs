// See https://aka.ms/new-console-template for more information

using ApplicationCore.Models.DomainModels;
using DataBaseInfrastructure.Migrations;
using DataBaseInfrastructure.Repositories;

InitMigration.Down();
InitMigration.Up();

var adminUser = new AdminUser(1, "password");
var adminUserRepository = new AdminUserRepository();
adminUserRepository.AddRegularUser("zayac1", adminUser);
adminUserRepository.ChangeSystemPassword("popabol'", adminUser);
Console.WriteLine(adminUserRepository.ShowLogHistory(adminUser.Id)[0].Message);

RegularUser regularUser = adminUserRepository.FindRegularUser(1, adminUser);
var regularUserRepository = new RegularUserRepository();
Console.WriteLine(regularUserRepository.ShowAccountBalance(regularUser));
regularUserRepository.RefillAccount(300, regularUser);
Console.WriteLine(regularUserRepository.ShowAccountBalance(regularUser));
regularUserRepository.WithdrawMoney(100, regularUser);
Console.WriteLine(regularUserRepository.ShowAccountBalance(regularUser));

// commands syntax:
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