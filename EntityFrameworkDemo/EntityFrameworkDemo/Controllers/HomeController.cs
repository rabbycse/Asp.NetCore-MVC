using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkDemo.Models;

namespace EntityFrameworkDemo.Controllers
{
    public class HomeController : Controller                                                                                                  
    {
        DemoContext _context;
        public HomeController(DemoContext context)                             
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Added 
            //_context.Users.Add(new SiteUser() { Name = "Rabbi", Username = "rabbicse", Password = "123456" });
            //_context.SaveChanges();
            //_context.Courses.Add(new Course() { Name = "Asp.Net Core MVC" });
            //_context.SaveChanges();

            // Remove 
            //var user = _context.Users.Where(x => x.Id == 2).FirstOrDefault();
            //_context.Users.Remove(user);
            //_context.SaveChanges();
            //var course = _context.Courses.Where(x => x.Id == 2).FirstOrDefault();
            //_context.Courses.Remove(course);
            // _context.SaveChanges();

            // Update 
            //course.Name = "asp.net core mvc"; 
            // _context.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
