using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    public class User
    {
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Status { get; private set; }

        public User(string name, string login, string password, string status)
        {
            Name = name;
            Login = login;
            Password = password;
            Status = status;
        }

        public bool Compare(User user)
        {
            if (Login == user.Login && Password == user.Password) return true;
            return false;
        }
    }
}
