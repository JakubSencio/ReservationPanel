using ASP.NET___Fixed_Version_2.Models;

namespace ASP.NET___Fixed_Version_2.Service
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        private int _nextId = 1;

        public int Add(Contact contact)
        {
            contact.Id = _nextId++;
            _contacts.Add(contact.Id, contact);
            return contact.Id;
        }

        public void Delete(int id)
        {
            _contacts.Remove(id);
        }

        public void Update(Contact contact)
        {
            _contacts[contact.Id] = contact;
        }

        public List<Contact> GetAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact GetById(int id)
        {
            return _contacts.ContainsKey(id) ? _contacts[id] : null;
        }
    }
}