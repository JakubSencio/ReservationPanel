using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASP.NET___Fixed_Version_2.Models
{
    public class Birth
    {
        public string Name { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && BirthDate < DateTime.Now;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - BirthDate.Year;
            if (BirthDate.Date > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}