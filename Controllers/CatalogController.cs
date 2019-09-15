using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;



namespace Project.Controllers
{
    public class CatalogController : Controller
    {
        private DataContext Context;

        public CatalogController(DataContext context)
        {
            Context = context;
        }
        public IActionResult index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult GetCatalog()
        {

            List<Car> list = Context.Cars.Where(c => c.Make != null).ToList();

            return Json(list);
        }

        [HttpPost]

        public IActionResult CreateCar([FromBody] Car newCar)
        {

            Console.WriteLine("Getting a CreateCar", newCar);

            Context.Cars.Add(newCar);
            Context.SaveChanges();

            Console.WriteLine();
            Console.WriteLine("******Saved!");
            Console.WriteLine();

            return Json(newCar);
        }
    }
}