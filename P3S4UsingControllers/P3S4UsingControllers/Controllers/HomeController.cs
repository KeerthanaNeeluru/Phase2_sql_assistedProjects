using Microsoft.AspNetCore.Mvc;
using P3S4UsingControllers.Models;
using System.Diagnostics;
using System.Text;

namespace P3S4UsingControllers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["message"] = "your application description page";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["message"] = "your application Contack page";
            return View();
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
        public IActionResult Info(String t)
        {
            ViewData["message"] = "you have requested info for" + t;
            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(String t)
        {
            StringBuilder sb = new StringBuilder("<b>Student Details entered ");

            sb.Append("Name : " + Request.Form["name"].ToString() + "<br>");
            sb.Append("Address : " + Request.Form["address"].ToString() + "<br>");
            sb.Append("Subject : " + Request.Form["subject"].ToString() + "<br>");
            ViewData["message"] = sb.ToString();
            return View();
        }
    }
}