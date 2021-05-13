using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    class AppUsers
    {
        public List<User> users = new List<User>();

        public bool KeepMeSigned = false;

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
