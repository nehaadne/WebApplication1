using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> options = new List<string>();
            options.Add("Select an option");
            options.Add("Yes");
            options.Add("No");
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form , ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.Option = form["options"];
            return View("Display");
        }
    }
}
