using Data.Entities;
using Labolatorium3.Models;

namespace Labolatorium3.Mappers
{
    public class ReservationMapper
    {
        public static Reservation FromEntity(ReservationEntity entity)   // Id Date City Region Room Name Price Prority Created
        {
            return new Reservation()
            {
                Id = entity.Id,
                Name = entity.Name,
                Region = entity.Region,
                City = entity.City,
                Date = entity.Date,
            };
        }

        public static ReservationEntity ToEntity(Reservation model)
        {
            return new ReservationEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Region = model.Region,
                City = model.City,
                Date = model.Date,
            };
        }
    }
}
