using ParserInfrastructure.DataContext;

namespace ApplicationCore.Services.DomainServices;

public interface IAdminServices
{
    bool Login(CommandContext commandContext);
    bool AddRegularUser(CommandContext commandContext);
    bool ChangeSystemPassword(CommandContext commandContext);
    bool ShowLogHistory(CommandContext commandContext);
}