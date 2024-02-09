using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string Name { get; set; } 
        public string Adress { get; set; }
        public string City { get; set; }
        public int Stars { get; set; }
        public ICollection<HotelOwner>? HotelOwners { get; set; }
    }
}