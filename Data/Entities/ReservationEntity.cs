using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Entities
{
    [Table("reservations")]
    public class ReservationEntity
    {
        [Key]
        public int Id { get; set; }  
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Region { get; set; }
        [MaxLength(12)]
        [MinLength(9)]
        public string City { get; set; }
        [Column("reservation_date")]
        public DateTime Date { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationEntity? Organization { get; set; }
        
        public int Room { get; set; }
        public int Price { get; set; }
        public int Priority { get; set; }
    }
}

