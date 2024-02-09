using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static Labolatorium3.Models.Enum;

namespace Labolatorium3.Models
{
    public class Reservation
    {

        [HiddenInput]
        public int Id { get; set; } //Reservation - data, miasto, adres, pokój, właściciel, cena 

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Proszę zaznaczyć datę")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Proszę podać miasto")]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Proszę podać adres")]
        [Display(Name = "Adress")]
        public string Region { get; set; }

        [Display(Name = "Numer pokoju")]
        public int Room { get; set; }

        [Required(ErrorMessage = "Proszę podać imię")]
        [Display(Name = "Właściciel")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę wpisać cenę")]
        [Range(0, int.MaxValue, ErrorMessage = "Proszę podać poprawną cenę")]
        [Display(Name = "Cena")]
        public int Price { get; set; }

        public Priority Priority { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }


        [HiddenInput]
        public int OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
