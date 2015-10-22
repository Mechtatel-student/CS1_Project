using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    public class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        public DummyDAOForClient()
        {
            _collection = Storage.Clients;
        }

        public ICollection<Client> FindBy(Person person, string city)
        {
            var result = _collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(person.FirstName))
            {
                result = result.Where(x => x.Person.FirstName == person.FirstName);
            }
            if (!string.IsNullOrWhiteSpace(person.MiddleName))
            {
                result = result.Where(x => x.Person.MiddleName == person.MiddleName);
            }
            if (!string.IsNullOrWhiteSpace(person.LastName))
            {
                result = result.Where(x => x.Person.LastName == person.LastName);
            }
            if (!string.IsNullOrWhiteSpace(city))
            {
                result = result.Where(x => x.ClientLocation.City == city);
            }
            return result.ToList();
        }
    }
}