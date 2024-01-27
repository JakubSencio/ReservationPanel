using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Labolatorium3.Models; // Zaimportuj odpowiednią przestrzeń nazw

public class ReservationController : Controller
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    public IActionResult Index()
    {
        var reservations = _reservationService.FindAll();
        return View(reservations);
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
            _reservationService.Add(model);
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
        var reservation = _reservationService.FindById(id);
        if (reservation == null)
        {
            return NotFound();
        }
        return View(reservation);
    }

    [HttpPost]
    public IActionResult Edit(Reservation model)
    {
        if (ModelState.IsValid)
        {
            _reservationService.Update(model);
            return RedirectToAction("Index");
        }
        else
        {
            return View(model);
        }
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        var reservation = _reservationService.FindById(id);
        if (reservation == null)
        {
            return NotFound();
        }
        return View(reservation);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var reservation = _reservationService.FindById(id);
        if (reservation == null)
        {
            return NotFound();
        }
        return View(reservation);
    }

    [HttpPost]
    public IActionResult Delete(Reservation model, int id)
    {
            _reservationService.Delete(id);
            return RedirectToAction("Index");
    }
}

