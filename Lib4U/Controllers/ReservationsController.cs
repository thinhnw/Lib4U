using Lib4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lib4U.Controllers
{
    public class ReservationsController : Controller
    {
        private ApplicationDbContext _context;
        public ReservationsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Reservations
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            var readers = _context.Readers.ToList();
            var books = _context.Books.ToList();
            var viewModel = new ReservationNewViewModel
            {
                Readers = readers,
                AvailableBooks = books,
                SelectedBooks = new List<Book>()                
            };
            return View(viewModel);
        }

        // POST: Reservations/Create
        [HttpPost]
        public ActionResult Create(Reservation reservation)
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

        // GET: Reservations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservations/Edit/5
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

        // GET: Reservations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservations/Delete/5
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
