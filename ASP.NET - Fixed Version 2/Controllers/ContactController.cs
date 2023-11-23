namespace ASP.NET___Fixed_Version_2.Controllers
{
    using ASP.NET___Fixed_Version_2.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ContactController : Controller
    {
        private static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();

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
            if (_contacts.ContainsKey(id))
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
                _contacts[model.Id] = model;
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
            if (_contacts.ContainsKey(id))
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
            if (_contacts.ContainsKey(id))
            {
                _contacts.Remove(id);
            }

            return RedirectToAction("Index");
        }
    }
}