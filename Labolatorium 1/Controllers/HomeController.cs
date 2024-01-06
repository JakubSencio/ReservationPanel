using Labolatorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Labolatorium_1.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About(Operator op)
        {
            ViewBag.Op = op;
            return View();
        }
        public IActionResult Calculator(double a, double b)
        {
            string op = Request.Query["op"];
            double c = a + b;
            op = c.ToString();
            ViewBag.Op = op;
            return View();         
        }
        public enum Operator
        {
            Unknown, Add, Mul, Sub, Divasdad
        }
    }
}