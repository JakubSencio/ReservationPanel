using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_3___4.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private readonly IDateTimeProvider _timeProvider;

        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public int Add(Contact contact)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            contact.Id = id + 1;
            contact.Created = _timeProvider.GetDateTime();
            _items.Add(contact.Id, contact);
            return contact.Id;  
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }

        public List<Contact> FindAll()
        {
            throw new NotImplementedException();
        }

        public Contact? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public interface IDateTimeProvider
        {
            DateTime GetDateTime();
        }
        public class CurrentDateTimeProvider : IDateTimeProvider
        {
            public DateTime GetDateTime()
            {
                return DateTime.Now;
            }
        }
    }
}