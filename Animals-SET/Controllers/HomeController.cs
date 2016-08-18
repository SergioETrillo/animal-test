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
            var listOfAnimals = Zoo.Members;
            ViewBag.ListOfAnimals = listOfAnimals;
            ViewBag.QuerybyName = QueryAnimals.GetAnimalsByName("Fluffy");
            ViewBag.QuerybyAge = QueryAnimals.GetAnimalsOlderThan(2);
            ViewBag.SortbyName = QueryAnimals.SortAnimalsByNameAge();
            ViewBag.OneAnimal = QueryAnimals.GetAnimalById(1);
            ViewBag.SerializedList = Zoo.SerializeList();

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