using Lib4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lib4U.Controllers
{
    public class BookSuggestionsController : Controller
    {
        private ApplicationDbContext _context;
        public BookSuggestionsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: BookSuggestions
        public ActionResult Index()
        {
            var models = _context.BookSuggestions.ToList();
            return View(models);
        }

        // GET: BookSuggestions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookSuggestions/Create
        public ActionResult Create()
        {
            var model = new BookSuggestion();
            return View(model);
        }

        // POST: BookSuggestions/Create
        [HttpPost]
        public ActionResult Create(BookSuggestion viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(viewModel);
                }
                
                _context.BookSuggestions.Add(viewModel);
                _context.SaveChanges();
                return RedirectToAction("Index");                
            }
            catch
            {
                return View(viewModel);
            }
        }

       

        // POST: BookSuggestions/Complete/5
        [HttpPost]
        public ActionResult Complete(int id, FormCollection collection)
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
