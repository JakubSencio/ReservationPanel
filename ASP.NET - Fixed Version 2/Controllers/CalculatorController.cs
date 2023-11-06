using ASP.NET___Fixed_Version_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET___Fixed_Version_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }

        public IActionResult About(Operator op)
        {
            ViewBag.Op = op;
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
