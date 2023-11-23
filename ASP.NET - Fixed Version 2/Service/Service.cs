using ASP.NET___Fixed_Version_2.Models;

namespace ASP.NET___Fixed_Version_2.Service
{
    public interface IContactService
    {
        int Add(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
        List<Contact> GetAll();
        Contact GetById(int id);
    }
}