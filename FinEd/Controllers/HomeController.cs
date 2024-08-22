using FinEd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinEd.Controllers
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

        public IActionResult Pension()
        {
            return View();
        }
        public IActionResult Savings()
        {
            return View();
        }

        public IActionResult Mortgages()
        {
            return View();
        }

        public IActionResult Tax()
        {
            return View();
        }

        public IActionResult PensionSection1()
        {
            return View("~/Views/Home/PensionPages/PensionSection1.cshtml");
        }

        public IActionResult PensionSection2()
        {
            return View("~/Views/Home/PensionPages/PensionSection2.cshtml");
        }

        public IActionResult PensionSection3()
        {
            return View("~/Views/Home/PensionPages/PensionSection3.cshtml");
        }

        public IActionResult PensionComplete()
        {
            return View("~/Views/Home/PensionPages/PensionComplete.cshtml");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
