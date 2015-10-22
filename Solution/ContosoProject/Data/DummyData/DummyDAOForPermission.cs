using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAOForPermission : DummyDAO<Permission>, IPermissionRepository
    {
        public DummyDAOForPermission()
        {
            _collection = Storage.Permissions;
        }
        public ICollection<Permission> GetByTitle(string title)
        {
            if (_collection.Any(x => x.Title == title))
            {
                return _collection.Where(x => x.Title == title).ToList();
            }
            throw new Exception();
        }
    }
}