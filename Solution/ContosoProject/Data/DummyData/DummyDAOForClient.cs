using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;

namespace Data.DummyData
{
    public class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        public DummyDAOForClient()
        {
            Collection = Storage.Clients;
        }

        public ICollection<Client> FindBy(string firstName, string lastName, string city)
        {
            var result = Collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                result = result.Where(x => x.Person.FirstName == firstName);
            }            
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                result = result.Where(x => x.Person.LastName == lastName);
            }
            if (!string.IsNullOrWhiteSpace(city))
            {
                result = result.Where(x => x.ClientLocation.City == city);
            }
            if (!Equals(result, Collection.AsQueryable()))
            {
                return result.ToList();
            }
            return null;
        }
    }
}