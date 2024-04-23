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
        [Required(ErrorMessage = "Please entry date")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please entry city")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please entry region")]
        [Display(Name = "Region")]
        public string Region { get; set; }

        [Display(Name = "Room")]
        public int Room { get; set; }

        [Required(ErrorMessage = "Please entry owner")]
        [Display(Name = "Owner")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please entry price")]
        [Range(0, int.MaxValue, ErrorMessage = "Please entry price")]
        [Display(Name = "Price")]
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
