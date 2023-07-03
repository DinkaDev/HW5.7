using HW5._6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW5._6.Controllers
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
            return View(new FormModel());
        }

        [HttpPost]
        public ActionResult Index(FormModel model)
        {
            Debug.WriteLine("First: " + model.First);
            Debug.WriteLine("Second: " + model.Second);
            Debug.WriteLine("Count: " + model.Count);
            return RedirectToAction("Index");
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