using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetDependencyDemo.Models
{
    public class Membership : IMembership
    {
        private UserData _data;
        public Membership(UserData data)
        {
            _data = data;
        }
        public bool IsUsernameAvailable(string username)
        {

            var user = _data.GetUser(username);
            if (user != null)
                return false;
            else
                return true;
        }
    }
}
