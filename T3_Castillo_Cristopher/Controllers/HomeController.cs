using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T3_Castillo_Cristopher.Models;

namespace T3_Castillo_Cristopher.Controllers
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

        //Libro de Arquitectura de Software
        public IActionResult LibroArqSoftware()
        {
            return View();
        }
        //Libro de Diseño de Software
        public IActionResult LibroDiseñoSoftware()
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