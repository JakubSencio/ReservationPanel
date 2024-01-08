using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result(double a, double b)
        {
            string op = Request.Query["op"];
            double c = a + b;
            op = c.ToString();
            ViewBag.Op = op;
            return View();
        }
        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }
    }
}
