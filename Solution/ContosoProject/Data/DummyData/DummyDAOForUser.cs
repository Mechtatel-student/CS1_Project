using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAOForUser : DummyDAOExtension<User>, IUserRepository
    {
        public DummyDAOForUser()
        {
            _collection = Storage.Users;
        }


        public ICollection<User> GetBy(string login, Person person)
        {
            var result = _collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
            {
                result = result.Where(x => x.Login == login);
            }
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
            return result.ToList();
        }

        public ICollection<User> GetByRole(Role role)
        {
            if (_collection.Any(x => x.Role == role))
            {
                return _collection.Where(x => x.Role == role).ToList();
            }
            throw new Exception();
        }
    }
}