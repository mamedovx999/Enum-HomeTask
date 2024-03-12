using Application;

namespace Services
{
  
        public interface IAccount
        {
            public bool checkRole(Account.Roles role);
            public bool login(string email, string password);
        }

    
}
