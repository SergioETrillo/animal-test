﻿using Animals_SET.Animals.Domain;
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
            var model =
                from a in Zoo.Members          
                orderby a.Name
                select a;
                        
                return View(model);
        }

        // GET: Animals/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                string name = Request.Form["Name"].ToLower();
                string type = Request.Form["Type"].ToLower();
                int age = Int32.Parse(Request.Form["Age"]);
                char gender = Convert.ToChar(Request.Form["Gender"].ToUpper());
                int id = Zoo.Members.Count + 1;  // To create a unique ID
                Animal animal;
                switch (type)
                {
                    case "bird":
                        animal = new Bird(name, age, gender);
                        break;
                    case "cat":
                        animal = new Cat(name, age, gender);
                        break;
                    case "dog":
                        animal = new Dog(name, age, gender);
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
            //var animal = _zoo.Single(a => a.Id == id);
            var animal = Zoo.Members.Single(a => a.Id == id);
            return View(animal);
        }

        // POST: Animals/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            //var animal = _zoo.Single(a => a.Id == id);
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
            return View();
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

        //static List<Animal> _zoo = new List<Animal>()
        //    {
        //        new Dog { Id = 1, Name = "Fluffy-group", Age = 33, Gender = 'M' },
        //        new Cat { Id = 2, Name = "Cattie-group", Age = 44, Gender = 'F'},
        //        new Bird {Id = 3, Name = "Tweety-group", Age = 11, Gender = 'M' }
        //    };
    }
}
