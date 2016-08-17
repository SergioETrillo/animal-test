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
            var listOfAnimals = GroupOfAnimals.Members();
            ViewBag.ListOfAnimals = listOfAnimals;
            ViewBag.QuerybyName = QueryAnimals.GetAnimalsByName("Fluffy");
            ViewBag.QuerybyAge = QueryAnimals.GetAnimalsOlderThan(2);
            //ViewBag.SortbyName = QueryAnimals.SortAnimalsByName();
            ViewBag.SerializedList = GroupOfAnimals.serializeList();

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