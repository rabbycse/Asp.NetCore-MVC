using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.NetDependencyDemo.Models;
using Asp.NetDependencyDemo.Code;

namespace Asp.NetDependencyDemo.Controllers
{
    public class HomeController : Controller
    {
        private IMembership _membership;

        public HomeController(IMembership membership)
        {

            //_membership = membership;
            //bool x = _membership.IsUsernameAvailable("Rabbi");

            SQLServerData data = new SQLServerData();
            data.GetStudentName();
        }
        public IActionResult Index()
        {
            Membership m = new Membership(new UserData());
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
