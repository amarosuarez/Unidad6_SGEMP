using Ej01U06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ej01U06.Controllers
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

        //public string Index()
        //{
        //    return "Hola Mundo!";
        //}

        public string Auri()
        {
            return "Auri";
        }

        public int num()
        {
            return 12;
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
