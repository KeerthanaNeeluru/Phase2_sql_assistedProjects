using Microsoft.AspNetCore.Mvc;
using P3S4FormSubmissionMethods.Models;
using System.Diagnostics;

namespace P3S4FormSubmissionMethods.Controllers
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
        public IActionResult FormGet()
        {
            ViewData["name"] = Request.Query["name"].ToString();
            ViewData["email"] = Request.Query["email"].ToString();
            ViewData["class"] = Request.Query["class"].ToString();
            ViewData["address"] = Request.Query["address"].ToString();
            return View();
        }
        [HttpPost]
        public IActionResult FormPost(string name,string email,string address,string whichclass)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["address"] = address;
            ViewData["class"] = whichclass;
            return View();
        }
        public IActionResult About()
        {
            ViewData["message"] = "your application description page";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["message"] = "your application contact page";
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
    }
}