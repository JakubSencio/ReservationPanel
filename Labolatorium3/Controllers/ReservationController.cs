using Labolatorium3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Labolatorium3.Controllers
{
    public class ReservationController : Controller
    {
        static Dictionary<int, Reservation> _reservation = new Dictionary<int, Reservation>();
        public IActionResult Index()
        {
            return View(_reservation);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reservation model)
        {
            if (ModelState.IsValid)
            {
                int id = _reservation.Keys.Count != 0 ? _reservation.Keys.Max() : 0;
                model.Id = id + 1;
                _reservation.Add(model.Id, model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (_reservation.ContainsKey(id))
            {
                return View(_reservation[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Edit(Reservation model)
        {
            if (ModelState.IsValid)
            {
                if (_reservation.ContainsKey(model.Id))
                {
                    _reservation[model.Id] = model;
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (_reservation.ContainsKey(id))
            {
                return View(_reservation[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (_reservation.ContainsKey(id))
            {
                _reservation.Remove(id);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}