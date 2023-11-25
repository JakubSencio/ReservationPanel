using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASP.NET_3___4.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")]
        Low = 1,

        [Display(Name = "Normalny")]
        Normal = 2,

        [Display(Name = "Wysoki")]
        High = 3,

        [Display(Name = "Pilny")]
        Urgent = 4
    }
}