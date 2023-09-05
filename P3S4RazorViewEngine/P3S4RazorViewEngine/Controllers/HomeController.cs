using Microsoft.AspNetCore.Mvc;
using P3S4RazorViewEngine.Models;
using System.Diagnostics;

namespace P3S4RazorViewEngine.Controllers
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
            if (Request.Query["t"] == "")
                ViewData["message"] = "Please select a list type";
            else if (Request.Query["t"] == "students")
            {
                ViewData["stype"] = "students";
                ViewData["message"] = "list of students";
                List<String> list=new List<String>();
                for(int i = 1; i <= 10; i++)
                {
                    list.Add("student " + i.ToString());
                }
                ViewData["list"] = list;
            }
            else if (Request.Query["t"] =="teachers")
            {
                ViewData["stype"] = "teachers";
                ViewData["message"] = "list of teachers";
                List<String> list = new List<String>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Teacher " + i.ToString());
                }
                ViewData["list"] = list;
            }
            return View();
        }
        public IActionResult About()
        {
            ViewData["message"] = "your application description page";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["message"] = "Your contact page";
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