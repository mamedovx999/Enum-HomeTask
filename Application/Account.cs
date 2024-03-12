using Enum_HomeTask;

namespace Application;

public class Account : IAccount
{
    public bool CheckRole(Roles role)
    {
        return role == Roles.SuperAdmin;
    }

    public void Login(User user)
    {
        if (user.Email == LoginData.LoginEmail
            && user.Password == LoginData.LoginPassword
            )
        {
            if (CheckRole(user.Role))
            {
                Console.WriteLine("Giris ugurlu oldu");
                return;
            }
            Console.WriteLine("Icazeniz yoxdur");
        }
        else
        {
            Console.WriteLine("Email ve ya password sefdir");
        }
    }
}