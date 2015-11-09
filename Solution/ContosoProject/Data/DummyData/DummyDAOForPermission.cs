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
            Collection = Storage.Permissions;
        }

        public new ICollection<Permission> GetAll()
        {
            return Collection;
        }

        public Permission GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Permission> GetByTitle(string title)
        {
            if (Collection.Any(x => x.Title == title))
            {
                return Collection.Where(x => x.Title == title).ToList();
            }
            throw new Exception();
        }
    }
}