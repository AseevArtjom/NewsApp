using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Domain.User
{
    public class UserList
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public List<User> GetUsers()
        {
            return users;
        }
    }
}
