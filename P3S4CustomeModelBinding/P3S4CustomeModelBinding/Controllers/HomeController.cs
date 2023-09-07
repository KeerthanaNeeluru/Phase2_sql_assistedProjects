using Microsoft.AspNetCore.Mvc;
using P3S4CustomeModelBinding.Models;
using System.Diagnostics;

namespace P3S4CustomeModelBinding.Controllers
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
        public IActionResult StudentEditView()
        {
            return View();
        }
        [HttpPost]
        public ContentResult StudentEditView(StudentModel model)
        {
            String result = model.Name + "," + model.Address + "," + model.Whichclass + "," + model.TotalMarks.ToString();
            return Content("form was submittes:\n"+result)
        }
    }
}