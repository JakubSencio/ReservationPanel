using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
