using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAOForRole : DummyDAO<Role>, IRoleRepository
    {
        public DummyDAOForRole()
        {
            _collection = Storage.Roles;
        }
        public ICollection<Role> GetByTitle(string title)
        {
            if (_collection.Any(x => x.Title == title))
            {
                return _collection.Where(x => x.Title == title).ToList();
            }
            else
                throw new Exception();
        }

        public ICollection<Role> GetByPermission(Permission permission)
        {
            if (_collection.Any(x => x.Permissions.Any(perm => perm == permission)))
            {
                return _collection.Where(x => x.Permissions.Any(perm => perm == permission)).ToList();
            }
            else
                throw new Exception();
        }
    }
}