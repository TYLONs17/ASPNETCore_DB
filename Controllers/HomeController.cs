using ASPNETCore_DB.Data;
using ASPNETCore_DB.Interfaces;
using ASPNETCore_DB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

//using System.Net.Mail;

namespace ASPNETCore_DB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SQLiteDBContext _context;
        private readonly IDBInitializer _seedDatabase;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, SQLiteDBContext context, IDBInitializer seedDatabase, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _seedDatabase = seedDatabase;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            ViewData["UserName"] = _userManager.GetUserName(this.User);

            if (this.User.IsInRole("Admin"))
            {
                ViewData["UserRole"] = "Admin";
            }
            else if (this.User.IsInRole("User"))
            {
                ViewData["UserRole"] = "User";
            }
            else
            {
                ViewData["UserRole"] = "Guest";
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            ViewData["UserName"] = _userManager.GetUserName(this.User);

            if (this.User.IsInRole("Admin"))
            {
                ViewData["UserRole"] = "Admin";
            }
            else
            {
                ViewData["UserRole"] = "User";
            }

            return View();
        }

        public IActionResult SeedDatabase()
        {
            //_seedDatabase.Initialize(_context);
            ViewBag.SeedDbFeedback = "Database created and Student Table populated with Data. Check Database folder.";
            return View("SeedDatabase");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public IActionResult Contact(ContactFormViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string selectedCampusEmail = model.CampusEmail;

        //        SendEmail(model.Name, model.Email, model.Message, selectedCampusEmail);

        //        return View("Success");
        //    }

        //    return View(); 
        //}

        //private void SendEmail(string name, string email, string message, string campusEmail)
        //{
        //    string recipientEmail = "";
        //    if (campusEmail == "BFN Campus")
        //    {
        //        recipientEmail = "CUTAdminBFN2024@gmail.com";
        //    }
        //    else if (campusEmail == "WLK Campus")
        //    {
        //        recipientEmail = "CUTAdminWLK2024@gmail.com";
        //    }
        //    else
        //    {
        //        throw new Exception("Invalid campus email selection");
        //    }

        //    var mailMessage = new MailMessage();
        //    mailMessage.From = new MailAddress(email);
        //    mailMessage.To.Add(new MailAddress(recipientEmail));
        //    mailMessage.Subject = "CUT | Studen Life Webpage Contact Form Submission";
        //    mailMessage.Body = $"Name: {name}\nEmail: {email}\nMessage: {message}";
        //    mailMessage.IsBodyHtml = false;

        //    var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server details
        //    smtpClient.Credentials = new NetworkCredential("youremail@example.com", "yourpassword"); // Replace with your credentials
        //    smtpClient.EnableSsl = true;
        //    smtpClient.Send(mailMessage);
        //}

    }
}