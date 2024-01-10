using Microsoft.AspNetCore.Mvc;
using Labolatorium_2.Models;

namespace Labolatorium_2.Controllers
{
    public class BirthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BirthFormModel());
        }

        [HttpPost]
        public IActionResult Index(BirthFormModel model)
        {
            if (model.IsValid())
            {
                int age = model.CalculateAge();
                ViewBag.Message = $"Cześć {model.Name}, masz {age} lat(a).";
            }
            else
            {
                ViewBag.ErrorMessage = "Wprowadź poprawne dane.";
            }

            return View(model);
        }
    }
}