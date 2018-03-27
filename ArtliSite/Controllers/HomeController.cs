using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using ArtliSite.Models;
using SimpleLogger;
using SimpleLogger.Logging.Handlers;

namespace ArtliSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Artli";

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
        public async Task<ActionResult> SendEmail(ContactModel model)
        {
            Logger.LoggerHandlerManager
                .AddHandler(new ConsoleLoggerHandler())
                .AddHandler(new FileLoggerHandler())
                .AddHandler(new DebugConsoleLoggerHandler());


            var result = new SendEmailResultModel();
            try
            {
                Logger.Log("ff");

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

                result.IsError = false;
                result.Message = "Thank you for contacting us. Our manager will contact you in the near time.";
               
            }
            catch (Exception ex)
            {
                result.IsError = true;
                result.Message = " Sorry we are facing some problem. Please, try later again.";
        
                //TODO: Add log
               
            }

            return PartialView(result);
        }

    }
}
