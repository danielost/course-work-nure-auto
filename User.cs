﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        public bool Compare(User user)
        {
            if (Login == user.Login && Password == user.Password) return true;
            return false;
        }
    }
}
