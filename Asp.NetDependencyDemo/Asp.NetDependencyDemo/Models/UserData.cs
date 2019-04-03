using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetDependencyDemo.Models
{
    public class UserData
    {
        private List<User> _users;

        public UserData()
        {
            _users = new List<User>();
            _users.Add(new User() { UserName = "Rabbi", Password = "123", Email = "rabby@gmail.com" });
            _users.Add(new User() { UserName = "Mosiur", Password = "123", Email = "mosiur@gmail.com" });
            _users.Add(new User() { UserName = "Mahmud", Password = "123", Email = "mahmud@gmail.com" });
        }

        public virtual User GetUser(string username)
        {
            foreach (var user in _users)
                if (user.UserName == username)
                    return user;
            return null;
        }
        public List<User> GetAllUsers()
        {
            return _users;
        }

        public static implicit operator List<object>(UserData v)
        {
            throw new NotImplementedException();
        }
    }
}
