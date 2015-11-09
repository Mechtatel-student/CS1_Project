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
            Collection = Storage.Users;
        }

        public ICollection<User> GetBy(string login, string firstName, string lastName)
        {
            var result = Collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
            {
                result = result.Where(x => x.Login == login);
            }
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                result = result.Where(x => x.Person.FirstName == firstName);
            }
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                result = result.Where(x => x.Person.LastName == lastName);
            }
            return result.ToList();
        }


        public ICollection<User> GetByRole(Role role)
        {
            if (Collection.Any(x => x.Role == role))
            {
                return Collection.Where(x => x.Role == role).ToList();
            }
            throw new Exception();
        }


        public User Authentificate(string login, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}