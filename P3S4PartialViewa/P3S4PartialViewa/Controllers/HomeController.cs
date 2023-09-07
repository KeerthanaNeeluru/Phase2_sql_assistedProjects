using Microsoft.AspNetCore.Mvc;
using P3S4PartialViewa.Models;
using System.Diagnostics;

namespace P3S4PartialViewa.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ViewResult StudentInfo()
        {
            return View();
        }
        public ViewResult TeacherInfo()
        {
            return View();
        }
    }
}