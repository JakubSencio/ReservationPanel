using Labolatorium3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Labolatorium3.Controllers
{
    public class ReservationController : Controller
    {
        
        static Dictionary<int, Reservation> _reservation = new Dictionary<int, Reservation>();
        public ReservationController()
        { 

        }
        public IActionResult Index()
        {
            return View(_reservation.ToList);
        }

        [HttpPost]
        public IActionResult Hotel(Reservation model)
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
                return View();
            }
        }
        [HttpGet]
        public IActionResult Hotel()
        {
            return View();
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
            if (_reservation.Keys.Contains(id))
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
                if (_reservation.Keys.Contains(model.Id))
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

        [HttpGet]
        public IActionResult Delete(string name, int id)
        {
            
            return View(new Reservation
            {
                Id = id,
                Name = name
            });
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