// See https://aka.ms/new-console-template for more information

using ApplicationCore.DomainModels;
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