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
            var viewModel = _context.Reservations.Select(rs => new ReservationListViewModel { Reservation = rs }).ToArray();
            return View(viewModel);
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
                SelectedBooks = new List<int>()                
            };
            return View(viewModel);
        }

        // POST: Reservations/Create
        [HttpPost]
        public ActionResult Create(ReservationNewViewModel viewModel)
        {
           
            if (!ModelState.IsValid)
            {
                viewModel.AvailableBooks = _context.Books.ToList();
                viewModel.Readers = _context.Readers.ToList();
                return View(viewModel);
            }                
            var reservations = new List<Reservation>();
            bool isSelectedBooksAvailable = true;
            viewModel.SelectedBooks.ForEach(bookId =>
            {
                Reservation reservation = new Reservation();
                reservation.ReaderId = viewModel.ReaderId;
                reservation.BookId = bookId;

                var book = _context.Books.Single(b => b.Id == bookId);
                if (book.AvailableQuantity == 0)
                {
                    AddError(book.Title + " is not available");
                    isSelectedBooksAvailable = false;
                }

                reservation.ReservedDate = DateTime.Now;
                reservation.DueDate = DateTime.Now.AddDays(14);
                reservations.Add(reservation);
            });
            if (!isSelectedBooksAvailable)
            {
                viewModel.AvailableBooks = _context.Books.ToList();
                viewModel.Readers = _context.Readers.ToList();
                return View(viewModel);
            }
            _context.Reservations.AddRange(reservations);
            reservations.ForEach(reservation =>
            {
                reservation.Book.AvailableQuantity--;
            });
            _context.SaveChanges();
            return RedirectToAction("Index");        
          
        }

        // GET: Reservations/Return/5        
        public ActionResult Return(int id)
        {
            
            var reservation = _context.Reservations.Single(rs => rs.Id == id);
            if (reservation.ReturnedDate != null)
            {
                reservation.ReturnedDate = DateTime.Now;
                reservation.Book.AvailableQuantity++;
                _context.SaveChanges();
            }            
            return RedirectToAction("Index");            
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
        private void AddError(string error)
        {
            ModelState.AddModelError("", error);
        }
    }

    
}
