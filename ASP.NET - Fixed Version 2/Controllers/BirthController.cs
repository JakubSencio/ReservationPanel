using Microsoft.AspNetCore.Mvc;

namespace ASP.NET___Fixed_Version_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Birth model)
        {
            if (model.IsValid())
            {
                int age = model.CalculateAge();
                ViewBag.Message = $"Cześć {model.Name}, masz {age} lat(a).";
            }
            return View(model);
        }
    }
}