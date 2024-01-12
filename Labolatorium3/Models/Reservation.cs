using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3.Models
{
    public class Reservation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HiddenInput]
        public int Id { get; set; } //Reservation - data, miasto, adres, pokój, właściciel, cena

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Proszę podać miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Proszę podać adres")]
        public string Region { get; set; }

        [Required(ErrorMessage = "Proszę podać numer pokoju")]
        public int Room { get; set; }

        [Required(ErrorMessage = "Proszę podać imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę wpisać cenę")]
        [Range(0, int.MaxValue, ErrorMessage = "Proszę podać poprawną cenę")]
        public int Price { get; set; }


    }
}
