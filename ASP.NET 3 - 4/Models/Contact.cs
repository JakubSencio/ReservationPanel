using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_3___4.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Proszę podać poprawny adres email.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data utworzenia")]
        public DateTime Created { get; set; }
    }
}
