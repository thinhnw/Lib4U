using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Lib4U.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Lib4U.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ReadersController : Controller
    {
        private ApplicationDbContext _context;                

        public ReadersController()
        {
            _context = new ApplicationDbContext();                                 
        }

        // GET: Readers        
        public ActionResult Index()
        {
            var readers = _context.Readers.ToList();
            return View(readers);
        }

        // GET: Readers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Readers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Readers/Create
        [HttpPost]
        public async Task<ActionResult> Create(ReaderCreateViewModel model)
        {
            try
            {                
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View("Create");
                }
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var reader = new Reader();
                    reader.Address = model.Address;
                    reader.FirstName = model.FirstName;
                    reader.LastName = model.LastName;
                    reader.MobilePhone = model.MobilePhone;
                    reader.UserId = user.Id;
                    _context.Readers.Add(reader);
                    _context.SaveChanges();

                    UserManager.AddToRole(user.Id, "Reader");

                    return RedirectToAction("Index");
                }
                AddErrors(result);
                // If we got this far, something failed, redisplay form
                return View(model);                
            }
            catch
            {
                return View();
            }
        }

        // GET: Readers/Edit/5
        public ActionResult Edit(int id)
        {
            var readerInDb = _context.Readers.Single(reader => reader.Id == id);
            var viewModel = new ReaderEditViewModel();
            viewModel.FirstName = readerInDb.FirstName;
            viewModel.LastName = readerInDb.LastName;
            viewModel.MobilePhone = readerInDb.MobilePhone;
            viewModel.Address = readerInDb.Address;
            return View(viewModel);
        }

        // POST: Readers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ReaderEditViewModel model)
        {
            try
            {
                // TODO: Add update logic here                
                if (!ModelState.IsValid)
                {
                    return View("Edit");
                }
                
                var readerInDb = _context.Readers.Single(reader => reader.Id == id);
                readerInDb.Address = model.Address;
                readerInDb.FirstName = model.FirstName;
                readerInDb.LastName = model.LastName;
                readerInDb.MobilePhone = model.MobilePhone;
                
                _context.SaveChanges();
                return RedirectToAction("Index");                                
            }
            catch
            {
                return View();
            }
        }

        // GET: Readers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Readers/Delete/5
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

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }


}
