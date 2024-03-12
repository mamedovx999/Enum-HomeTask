﻿
using Services;

namespace Application
{
    public class Account: IAccount
    {
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public bool checkRole(Roles role)
        {
            if (role == Roles.SuperAdmin) return true;
            else return false;
        }

        public bool login(string email, string password)
        {
            if (email == Constants.correctMail && password == Constants.correctPassword)
                return true;
            else return false;
        }

        public enum Roles
        {
            SuperAdmin,
            Admin,
            Member
        }
    }
}
}
