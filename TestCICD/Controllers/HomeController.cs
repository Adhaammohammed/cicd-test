using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestCICD.Models;

namespace TestCICD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View(new TestModel());
        }
        [HttpPost]
        public IActionResult Index(TestModel model)
        {
            if (ModelState.IsValid)
            {
                model.result = model.firstParam + model.secondParam;
                return View(model);
            }
            return View(model);
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
