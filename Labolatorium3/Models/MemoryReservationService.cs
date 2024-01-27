using System.Collections.Generic;

namespace Labolatorium3.Models
{
    public interface IReservationService
    {
        int Add(Reservation reservation);
        void Delete(int id);
        void Update(Reservation reservation);
        List<Reservation> FindAll();
        Reservation? FindById(int id);

    }

    public class MemoryReservationService : IReservationService
    {
        private Dictionary<int, Reservation> _items = new Dictionary<int, Reservation>();

        public int Add(Reservation item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Reservation> FindAll()
        {
            return _items.Values.ToList();
        }

        public Reservation? FindById(int id)
        {
            return _items.ContainsKey(id) ? _items[id] : null;
        }

        public void Update(Reservation item)
        {
            _items[item.Id] = item;
        }
    }
}
