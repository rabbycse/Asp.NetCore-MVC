using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetDependencyDemo.Models
{
    public class SpecialUserData : UserData
    {
        public override User GetUser(string username)
        {
            return base.GetUser(username);
        }
    }
}
