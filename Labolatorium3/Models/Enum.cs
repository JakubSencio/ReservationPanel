using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3.Models
{
    public class Enum : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public enum Priority
        {
            Low = 1,
            Normal = 2,
            High = 3,
            Urgent = 4
        }
    }
}
