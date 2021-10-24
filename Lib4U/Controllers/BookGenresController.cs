using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lib4U.Models;

namespace Lib4U.Controllers
{
    public class BookGenresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BookGenres
        public ActionResult Index()
        {
            var bookGenres = db.BookGenres.Include(b => b.Books).Include(b => b.Genres);
            return View(bookGenres.ToList());
        }

        // GET: BookGenres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookGenre bookGenre = db.BookGenres.Find(id);
            if (bookGenre == null)
            {
                return HttpNotFound();
            }
            return View(bookGenre);
        }

        // GET: BookGenres/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "Id", "Title");
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name");
            return View();
        }

        // POST: BookGenres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BookId,GenreId")] BookGenre bookGenre)
        {
            if (ModelState.IsValid)
            {
                db.BookGenres.Add(bookGenre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "Id", "Title", bookGenre.BookId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", bookGenre.GenreId);
            return View(bookGenre);
        }

        // GET: BookGenres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookGenre bookGenre = db.BookGenres.Find(id);
            if (bookGenre == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Title", bookGenre.BookId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", bookGenre.GenreId);
            return View(bookGenre);
        }

        // POST: BookGenres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BookId,GenreId")] BookGenre bookGenre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookGenre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Title", bookGenre.BookId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", bookGenre.GenreId);
            return View(bookGenre);
        }

        // GET: BookGenres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookGenre bookGenre = db.BookGenres.Find(id);
            if (bookGenre == null)
            {
                return HttpNotFound();
            }
            return View(bookGenre);
        }

        // POST: BookGenres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookGenre bookGenre = db.BookGenres.Find(id);
            db.BookGenres.Remove(bookGenre);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
