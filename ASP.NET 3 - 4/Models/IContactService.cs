using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_3___4.Models
{
    public interface IContactService
    {
        int Add(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
        List<Contact> FindAll();
        Contact? FindById(int id);
    }
}