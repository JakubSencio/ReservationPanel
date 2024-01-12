using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public String Edit(int? id)
        {
            return "Edycja " + id;
        }
    }
}
