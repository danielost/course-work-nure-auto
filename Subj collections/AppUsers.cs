using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    class AppUsers
    {
        public List<User> users = new List<User>();

        //public User current;
        public bool Search(User toFind)
        {
            foreach(User user in users)
            {
                if (toFind.Compare(user))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
