using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lib4U.Controllers
{
    public class BookSuggestionsController : Controller
    {
        // GET: BookSuggestions
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookSuggestions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookSuggestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookSuggestions/Create
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

        // GET: BookSuggestions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookSuggestions/Edit/5
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

        // GET: BookSuggestions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookSuggestions/Delete/5
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
