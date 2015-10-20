using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IRepositoryExtension<T> : IRepository<T>
    {
        ICollection<T> GetByUser(User user);
        ICollection<T> GetByDate(DateTime date);
    }
}