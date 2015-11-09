using System.Collections.Generic;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IPermissionRepository
    {
        Permission GetById(int id);
        ICollection<Permission> GetByTitle(string title);
        ICollection<Permission> GetAll();
    }
}
