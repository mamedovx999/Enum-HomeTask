using Application;

namespace Enum_HomeTask;

public class User
{
    public User(string email, string password, Roles role)
    {
        Email = email;
        Password = password;
        Role = role;
    }

    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public Roles Role { get; set; } 
}
