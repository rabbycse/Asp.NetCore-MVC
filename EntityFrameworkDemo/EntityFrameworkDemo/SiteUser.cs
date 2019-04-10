using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class SiteUser
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public virtual List<Course> Courses { get; set; } 
        
    }
}
