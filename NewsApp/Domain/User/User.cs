using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Domain.User
{
    public class User
    {
        private string Email;
        private string Password;
        private string UserName;
        public User(string email, string password, string userName)
        {
            Email = email;
            Password = password;
            UserName = userName;
        }
        public User()
        {
            Email = "";
            Password = "";
            UserName = "Guest";
        }
        public string GetEmail()
        {
            return Email;
        }

        public string GetPassword()
        {
            return Password;
        }
        public string GetUserName()
        {
            return UserName;
        }
    }
}
