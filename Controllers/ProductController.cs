using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
namespace WebApplication1.Controllers

{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product{Id=101, Name="HP Laptop", Price=44000},
                new Product{Id=102, Name="Dell Laptop", Price=43000},
                new Product{Id=103, Name="Lenovo Laptop", Price=42000},
            };

            ViewBag.ProductList = plist;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        //[HttpGet] //by default it is HttpGet
        //public IActionResult Create()
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];
            return View("Details");


        }
    }
}
