using System.Globalization;
using ApplicationCore.Models.DomainModels;
using ApplicationCore.Services.DomainServices;
using DataBaseInfrastructure.Repositories;
using ParserInfrastructure.DataContext;

namespace ApplicationCore.Services.Services;

public class RegularUserServices : IRegularUserServices
{
    private static RegularUser? _regularUser;
    private RegularUserRepository _regularUserRepository = new RegularUserRepository();

    public bool Login(CommandContext commandContext)
    {
        _regularUser = null;
        _regularUser = _regularUserRepository.FindRegularUser(Convert.ToInt32(commandContext.FlagDictionary["-i"], new NumberFormatInfo()), commandContext.FlagDictionary["-p"]);
        if (_regularUser == null)
        {
            Console.WriteLine("The id or password was incorrect");
            return false;
        }

        return true;
    }

    public int ShowAccountBalance(CommandContext commandContext)
    {
        if (_regularUser == null)
        {
            Console.WriteLine("The user has not logged in");
            return -1;
        }

        return _regularUserRepository.ShowAccountBalance(_regularUser);
    }

    public int WithdrawMoney(CommandContext commandContext)
    {
        if (_regularUser == null)
        {
            Console.WriteLine("The user has not logged in");
            return -1;
        }

        return _regularUserRepository.WithdrawMoney(
            Convert.ToInt32(commandContext.FlagDictionary["-b"], new NumberFormatInfo()), _regularUser);

        // "-1" - код ошибки. Если возвратит ее, то либо недостаточно денег на счету, или незалогинен юзер
    }

    public int RefillAccount(CommandContext commandContext)
    {
        if (_regularUser == null)
        {
            Console.WriteLine("The user has not logged in");
            return -1;
        }

        return _regularUserRepository.RefillAccount(
            Convert.ToInt32(commandContext.FlagDictionary["-b"], new NumberFormatInfo()), _regularUser);
    }

    public bool ShowLogHistory(CommandContext commandContext)
    {
        if (_regularUser == null)
        {
            Console.WriteLine("The user has not logged in");
            return false;
        }

        IList<Log> loglist = _regularUserRepository.ShowLogHistory(_regularUser);
        for (int i = 0; i < loglist.Count; ++i)
        {
            Console.WriteLine($"Log -> Id:{loglist[i].LogId}, UserId:{loglist[i].UserId}, UserType:{loglist[i].UserType}, Message:{loglist[i].Message}");
        }

        return true;
    }
}