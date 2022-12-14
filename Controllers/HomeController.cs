using GoodProduct.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoodProduct.Controllers
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
            return View("About");
        }

        public IActionResult Contact()
        {
            return View("Contact");
        }

        public IActionResult Client()
        {
            return View("Client");
        }

        public IActionResult Products()
        {
            return View("Products");
        }

        public IActionResult Blog()
        {
            return View("Blog");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}