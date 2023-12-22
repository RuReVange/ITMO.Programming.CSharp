using ApplicationCore.DomainModels;

namespace Abstractions.Repositories;

public interface IAdminUserRepository
{
    bool AddRegularUser(string password, AdminUser adminUser);
    bool ChangeSystemPassword(string newPassword, AdminUser adminUser);
    RegularUser? FindRegularUser(int id, AdminUser adminUser);
    IList<Log> ShowLogHistory(int id);
}