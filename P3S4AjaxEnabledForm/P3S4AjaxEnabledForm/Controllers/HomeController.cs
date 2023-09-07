using Microsoft.AspNetCore.Mvc;
using P3S4AjaxEnabledForm.Models;
using System.Diagnostics;
using System.Text;

namespace P3S4AjaxEnabledForm.Controllers
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
        public IActionResult Index(StudentModel model)
        {
            StringBuilder sb = new StringBuilder("Form Data :\n");
            sb.Append(model.Name + "," + model.Address + "," + model.Email + "," + model.Class);
            return Content(sb.ToString());
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