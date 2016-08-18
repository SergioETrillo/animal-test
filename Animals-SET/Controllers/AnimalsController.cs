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
            //var Animals = GroupOfAnimals.Members();
            var model =
                from r in GroupOfAnimals.Members()
                orderby r.Name
                select r;
                        
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
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animals/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
    }
}
