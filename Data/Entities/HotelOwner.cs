using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class HotelOwner
    {
        [Key]
        public int OwnerId { get; set; }
        public string Name { get; set; }  
        public string LastName{ get; set; }
        public string Mail { get; set; }
        public ICollection<Hotel>? Hotels{ get; set; }
    }
}
