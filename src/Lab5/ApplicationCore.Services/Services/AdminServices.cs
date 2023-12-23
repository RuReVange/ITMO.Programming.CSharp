using System.Globalization;
using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.DomainServices;
using DataBaseInfrastructure.Repositories;

namespace ApplicationCore.Services.Services;

public class AdminServices : IAdminServices
{
    private static AdminUser? _adminUser;
    private AdminUserRepository _adminUserRepository = new AdminUserRepository();

    public bool Login(CommandContext commandContext)
    {
        _adminUser = null;
        _adminUser = _adminUserRepository.FindAdminUser(commandContext.FlagDictionary["-p"]);
        if (_adminUser == null)
        {
            Console.WriteLine("The system The id or password was incorrectpassword was incorrect");
            System.Environment.Exit(0);
        }

        return true;
    }

    public bool AddRegularUser(CommandContext commandContext)
    {
        if (_adminUser == null)
        {
            Console.WriteLine("The admin has not logged in");
            return false;
        }

        return _adminUserRepository.AddRegularUser(commandContext.FlagDictionary["-p"], _adminUser);
    }

    public bool ChangeSystemPassword(CommandContext commandContext)
    {
        if (_adminUser == null)
        {
            Console.WriteLine("The admin has not logged in");
            return false;
        }

        return _adminUserRepository.ChangeSystemPassword(commandContext.FlagDictionary["-p"], _adminUser);
    }

    public bool ShowLogHistory(CommandContext commandContext)
    {
        if (_adminUser == null)
        {
            Console.WriteLine("The admin has not logged in");
            return false;
        }

        IList<Log> loglist = _adminUserRepository.ShowLogHistory(Convert.ToInt32(commandContext.FlagDictionary["-i"], new NumberFormatInfo()));
        for (int i = 0; i < loglist.Count; ++i)
        {
            Console.WriteLine($"Log -> Id:{loglist[i].LogId}, UserId:{loglist[i].UserId}, UserType:{loglist[i].UserType}, Message:{loglist[i].Message}");
        }

        return true;
    }

    public void Logout()
    {
        _adminUser = null;
    }
}