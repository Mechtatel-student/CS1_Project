using System.Collections.Generic;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IRoleRepository : IRepository<Role>
    {
        ICollection<Role> GetByTitle(string title);
        ICollection<Role> GetByPermission(Permission permission);
    }
}
