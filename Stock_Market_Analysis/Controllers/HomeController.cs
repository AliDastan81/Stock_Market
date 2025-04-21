using Microsoft.AspNetCore.Mvc;
using Stock_Market_Analysis.Models;
using System.Diagnostics;

namespace Stock_Market_Analysis.Controllers
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
            int k = 1;
            int z = 45;
            int s = 45;
            return View();
        }

        public IActionResult Privacy()
        {
            int z = 8;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            int f = 87;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
