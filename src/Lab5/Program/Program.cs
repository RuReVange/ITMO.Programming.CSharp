// See https://aka.ms/new-console-template for more information

using ApplicationCore.DomainModels;
using DataBaseInfrastructure.Migrations;
using DataBaseInfrastructure.Repositories;

InitMigration.Down();
InitMigration.Up();

var adminUser = new AdminUser(23, "prosto");
var adminUserRepository = new AdminUserRepository(adminUser);
adminUserRepository.AddRegularUser("zayac1");
adminUserRepository.ChangeSystemPassword(1, "popabol'");
Console.WriteLine(adminUserRepository.ShowLogHistory()[0].Message);

var regularUserRepository = new RegularUserRepository(adminUserRepository.FindRegularUser(1));
Console.WriteLine(regularUserRepository.ShowAccountBalance());
regularUserRepository.RefillAccount(300);
Console.WriteLine(regularUserRepository.ShowAccountBalance());
regularUserRepository.WithdrawMoney(100);
Console.WriteLine(regularUserRepository.ShowAccountBalance());