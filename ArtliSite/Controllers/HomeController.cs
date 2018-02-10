using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using ArtliSite.Models;

namespace ArtliSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Portfolio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var email = new MailMessage();
                    email.From = new MailAddress(model.Email);
                    email.To.Add("artlisoft.info@gmail.com");
                    email.Subject = model.Subject;
                    email.Body = model.ToString();

                    var smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("artlisoft.smm@gmail.com", "qwe123rty!QAZoiu");
                    smtp.EnableSsl = true;
                    
                    await smtp.SendMailAsync(email);
                    ModelState.Clear();

                    ViewBag.Message = "Thank you for Contacting us ";
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View(model);
        }

    }
}
