using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo
{
    public class Course
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }                         
        //public int UserId { get; set; }                                                                                                                                      
       
    }
}