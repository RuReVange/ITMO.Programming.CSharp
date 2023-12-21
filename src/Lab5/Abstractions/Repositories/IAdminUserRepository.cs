using ApplicationCore.DomainModels;

namespace Abstractions.Repositories;

public interface IAdminUserRepository
{
    bool AddRegularUser(string password);
    bool ChangeSystemPassword(int adminUserId, string newPassword);
    RegularUser? FindRegularUser(int id);
    IList<Log> ShowLogHistory();
}