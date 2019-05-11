using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions options) :
            base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SiteUser>().ToTable("Users");
            modelBuilder.Entity<SiteUser>().HasMany(u => u.Courses).WithOne(c => c.User).HasForeignKey(c => c.UserId);
            //modelBuilder.Entity<Course>().HasOne(u => u.User).WithMany(c => c.Courses).HasForeignKey(c => c.UserId); 

        }
        public DbSet<SiteUser> Users { get; set; }
        public DbSet<Course> Courses { get; set; } 
    }
}
