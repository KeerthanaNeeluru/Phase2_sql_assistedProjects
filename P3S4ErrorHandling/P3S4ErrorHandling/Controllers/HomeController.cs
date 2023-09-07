using Microsoft.AspNetCore.Mvc;
using P3S4ErrorHandling.Models;
using System.Diagnostics;

namespace P3S4ErrorHandling.Controllers
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
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int age = Convert.ToInt16(form["age"]);
            return View();
        }
        [HttpPost]
        public ActionResult Index2(FormCollection form)
        {
            try
            {
                int age = Convert.ToInt16(form["age"]);
            }
            catch(Exception ex)
            {
             
                throw ex;
            }
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