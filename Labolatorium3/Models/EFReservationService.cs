using Data;
using Data.Entities;
using Labolatorium3.Mappers;

namespace Labolatorium3.Models
{
    public class EFReservationService : IReservationService
    {
        private AppDbContext _context;

        public EFReservationService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Reservation reservation)
        {
            var e = _context.Reservations.Add(ReservationMapper.ToEntity(reservation));
            _context.SaveChanges();
            return e.Entity.Id;
        }
         
        public void Delete(int id)
        {
            ReservationEntity? find = _context.Reservations.Find(id);
            if (find != null)
            {
                _context.Reservations.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Reservation> FindAll()
        {
            return _context.Reservations.Select(e => ReservationMapper.FromEntity(e)).ToList(); ;
        }

        public List<OrganizationEntity> FindAllOrganizationsForVieModel()
        {
            return _context.Organizations.ToList();
        }

        public Reservation? FindById(int id)
        {
            return ReservationMapper.FromEntity(_context.Reservations.Find(id));
        }

        public void Update(Reservation reservation)
        {
            _context.Reservations.Update(ReservationMapper.ToEntity(reservation));
            _context.SaveChanges();
        }
    }
}