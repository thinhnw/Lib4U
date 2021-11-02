using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lib4U.Models;

namespace Lib4U.Controllers
{   
    public class ClientController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Client

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int? id)
        {
            var query = from book in db.Books
                        join bookAuthor in db.BookAuthors on book.Id equals bookAuthor.Id
                        where id == book.Id
                        join author in db.Authors on bookAuthor.Id equals author.Id
                        join publisher in db.Publishers on book.PublisherId equals publisher.Id
                        select new BookAndMedia
                        {
                            Id = book.Id,
                            Title = book.Title,
                            Image = book.Image,
                            Total_pages = book.Total_pages,
                            Rating = book.Rating,
                            First_name = author.First_name,
                            Last_name = author.Last_name,
                            PublisherName = publisher.Name
                        };
           
            foreach (BookAndMedia item in query)
            {
                var listBook = item;
                return View(listBook);
            }
            return RedirectToAction("BookAndMedia");
        }
        public ActionResult BookAndMedia()
        {
            var query = from book in db.Books
                        join bookAuthor in db.BookAuthors on book.Id equals bookAuthor.Id
                        join author in db.Authors on bookAuthor.Id equals author.Id
                        join publisher in db.Publishers on book.PublisherId equals publisher.Id
                        select new BookAndMedia { 
                                    Id = book.Id,
                                    Title = book.Title,
                                    Image = book.Image,
                                    Total_pages=  book.Total_pages,
                                    Rating = book.Rating,
                                    First_name = author.First_name,
                                    Last_name = author.Last_name,
                                    PublisherName = publisher.Name
                        };
            var listBook = query.ToList();
            return View(listBook);
        }

        public ActionResult BookAndMediaView2()
        {
            return View();
        }
    }
}