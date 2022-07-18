using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is my mvc application";
            string[] names = { "Neha", "Jivan", "Bhushan", "Rahul" };
            ViewData["nameslist"] = names;

            List<Employee> emplist = new List<Employee>()
            {
            new Employee{Id=1, Name="Neha",Department="IT",Salary=25000},
            new Employee { Id = 2, Name = "Jivan", Department = "BA", Salary = 28000 },
            new Employee { Id = 3, Name = "Mansi", Department = "IT", Salary = 30000 },
            new Employee { Id = 4, Name = "Amit", Department = "IT", Salary = 25000 }

        };
        ViewData["emplist"]=emplist;

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
