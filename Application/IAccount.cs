using Enum_HomeTask;
using System.Data;

namespace Application;

public interface IAccount
{
    bool CheckRole(Roles role);
    void Login(User user);
}
