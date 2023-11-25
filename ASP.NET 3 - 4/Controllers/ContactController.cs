using ASP.NET_3___4.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_3___4.Controllers
{
    public class ContactController : Controller
    {
        static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                int id = _contacts.Keys.Count != 0 ? _contacts.Keys.Max() : 0;
                model.Id = id + 1;
                _contacts.Add(model.Id, model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_contacts);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (_contacts.Keys.Contains(id))
            {
                return View(_contacts[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Edit(Contact model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (_contacts.Keys.Contains(id))
            {
                return View(_contacts[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_contacts.Keys.Contains(id))
            {
                _contacts.Remove(id);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (_contacts.Keys.Contains(id))
            {
                return View(_contacts[id]);
            }
            else
            {
                return NotFound();
            }
        }
    }
}