using Lib4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Complete(int id, FormCollection collection)
        {
            
                // TODO: Add update logic here
                SendMailController reservations = new SendMailController();
                var books = (from book in _context.Books where book.Rating >= 4 select book);
                foreach (var book in books) {
                  await reservations.SendEmail("Chúng tôi đã nhận yêu cầu mua sách của bạn", book.Title, "https://localhost:44371/Client/Detail/" + book.Id, book.Publisher.Name); ;
                }
                return RedirectToAction("Index");
            
            
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
