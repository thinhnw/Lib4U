using Lib4U.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Web.Hosting;

namespace Lib4U.Controllers
{
    public class SendMailController : Controller
    {
        private ApplicationDbContext _context;
        public SendMailController()
        {
            _context = new ApplicationDbContext();
        }
        public string EMailTemplate(string template)
        {
            string body = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/Content/template/") + template + ".html");
            return body.ToString();
        }
        // GET: SendMail
        public Reservation Reservation = new Reservation();

        public async Task<ActionResult> SendEmail(string subjectMail,string contentMail)
        {

            string settingContent = null;
            string combineBookName = null;
            DateTime date = DateTime.Now.AddDays(12);
            var reservation_db = _context.Reservations.Where(x => DbFunctions.DiffDays(x.DueDate, date) <= 3).Select(rs => new ReservationListEmail { Reservation = rs }).ToArray();
            foreach (var item in reservation_db)
            {
                List<string> bookName = new List<string>();
                if (settingContent == null)
                {
                    foreach (var itemRes in reservation_db)
                    {
                        if (itemRes == item)
                        {
                            try
                            {
                                bookName = _context.Reservations.Where(x => x.Id == itemRes.Reservation.Id).Select(res => res.Book.Title).ToList();
                                foreach (var name in bookName)
                                {
                                    combineBookName += name + " ";

                                }
                                System.Diagnostics.Debug.WriteLine(combineBookName);
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                    }
                    contentMail = combineBookName;
                    combineBookName = null;
                }

                if (subjectMail == null)
                {
                    subjectMail = "Hạn trả sách của bạn vào ngày :" + item.Reservation.DueDate.Date.ToString();
                }
                var content = EMailTemplate("email");
                content = content.Replace("{{CustomerName}}", "Le Dat");
                content = content.Replace("{{Phone}}", "09123123123");
                content = content.Replace("{{Email}}", item.StudentMail);
                content = content.Replace("{{Address}}", "hanoi");
                content = content.Replace("{{Content}}", contentMail);
                new Common.Class1().ConfigMail(item.StudentMail, "Library", subjectMail, content);

                //End Email
            }
            return Json(0, JsonRequestBehavior.AllowGet);


        }
    }
}