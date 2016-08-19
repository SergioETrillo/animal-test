using Animals_SET.Animals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animals_SET.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals
        public ActionResult Index()
        {
            var model = QueryAnimals.SortAnimalsByNameAge();
                        
                return View(model);
        }

        // GET: Animals/Details/5
        public ActionResult Details(int id)
        {
            var model = QueryAnimals.GetAnimalById(id);

            return View(model);
        }

        // GET: Animals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animals/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                // pending input validation try-catch?
                string name = Request.Form["Name"].ToLower();
                string type = Request.Form["Type"].ToLower();
                int age = Int32.Parse(Request.Form["Age"]);  
                char gender = Convert.ToChar(Request.Form["Gender"].ToUpper());
                int id = ++Zoo.WaterMarkCount;  // To create a unique ID
                Animal animal;
                switch (type)
                {
                    case "bird":
                        animal = new Bird(id, name, age, gender);
                        break;
                    case "cat":
                        animal = new Cat(id, name, age, gender);
                        break;
                    case "dog":
                        animal = new Dog(id, name, age, gender);
                        break;
                    default:
                        return RedirectToAction("Index"); // Error handling missing
                }
                Zoo.Members.Add(animal);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Animals/Edit/5
        public ActionResult Edit(int id)
        {
            var animal = Zoo.Members.Single(a => a.Id == id);

            return View(animal);  
        }

        // POST: Animals/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var animal = Zoo.Members.Single(a => a.Id == id);
            if (TryUpdateModel(animal))
            {                
                return RedirectToAction("Index");
            }

            return View(animal);
        }

        // GET: Animals/Delete/5
        public ActionResult Delete(int id)
        {
            var model = QueryAnimals.GetAnimalById(id);
            Zoo.Members.Remove(model);
            return View(model);
        }

        // POST: Animals/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
