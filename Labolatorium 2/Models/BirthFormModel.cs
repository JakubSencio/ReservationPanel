using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_2.Models
{
    public class BirthFormModel
    {
        [Required(ErrorMessage = "Pole 'Imię' jest wymagane.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole 'Data urodzenia' jest wymagane.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && BirthDate < DateTime.Now;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - BirthDate.Year;

            if (currentDate.Month < BirthDate.Month || (currentDate.Month == BirthDate.Month && currentDate.Day < BirthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
   }