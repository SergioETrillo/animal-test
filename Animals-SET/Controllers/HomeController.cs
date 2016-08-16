using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animals_SET.Animals.Domain;

namespace Animals_SET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var listOfAnimals = new List<Animal>()
            {
                new Dog { Name = "Flufly", Age = 3, Gender = 'M' },
                new Cat { Name = "Cattie", Age = 4, Gender = 'F'},
                new Bird { Name = "Tweety", Age = 1, Gender = 'M' }
            };

            ViewBag.ListOfAnimals = listOfAnimals;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}