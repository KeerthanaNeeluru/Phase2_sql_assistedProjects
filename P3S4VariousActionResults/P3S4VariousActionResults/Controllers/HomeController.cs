using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using P3S4VariousActionResults.Models;
using System.Diagnostics;

namespace P3S4VariousActionResults.Controllers
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
        public ContentResult StudentAsString()
        {
            return Content("The name of student is WlterSmith an dhe is in grade 7.");
        }
        public ViewResult StudentAsView()
        {
            ViewData["message"] = "The name od student is <b> Walter Smith</b>and he is in grade 7.";

            return View();
        }
        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https//www.bing.com/search?q=walter+smith");
        }
        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return new RedirectToRouteResult(new
            {
                control
            = "Home",
                action = "StudentAsView"
            });
        }
        public FileResult StudentAsFileResult()
        {
            byte[] filebytes = System.IO.File.ReadAllBytes(@"./www.root/StudentData.txt");
            string filename = "StudentData.txt";
            return File(filebytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);

        }
        public JsonResult StudentAsJSONResult()
        {
            string data = System.IO.File.ReadAllText(@"./www.root/StudentData.JSON");
            JObject json=JObject.Parse(data);
            return Json(json);
        }
        public ViewResult StudentList()
        {
            return View();
        }
    }
}