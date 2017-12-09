using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;
namespace TP.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBEntities _db = new MoviesDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Table.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View(_db.Table.Single(movie => movie.Id == id));

        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Movie movieToCreate)
        {
            try
            {
                // TODO: Add insert logic here

                if (!ModelState.IsValid)

                    return View();

                _db.Table.Add(movieToCreate);

                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(_db.Table.Single(movie => movie.Id == id));
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Movie movieToDelete)
        {
            try
            {
                // TODO: Add delete logic here

                movieToDelete = _db.Table.Single(movie => movie.Id == id);
                _db.Table.Remove(movieToDelete);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

}
