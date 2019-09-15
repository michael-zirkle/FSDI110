using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;



namespace Project.Controllers

{
    public class RepresentativeController : Controller {

        private DataContext Context;
        public RepresentativeController(DataContext context){

            Context = context;
        }

        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult GetList()
        {
          List<Representative> list = Context.Representatives.ToList(); 

          return  Json(list); 
        }

        public IActionResult Save([FromBody] Representative newRep)
        {
            Context.Representatives.Add(newRep);
            Context.SaveChanges();

            return Json(newRep);
        }
    }
}