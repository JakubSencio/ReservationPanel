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
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayAttribute = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            return displayAttribute?.Name ?? enumValue.ToString();
        }
    }
}