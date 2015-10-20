using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAO
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Save(T entity);
        void Delete(T entity);
        void Delete(int id);
        T Find(int id);

        ICollection<T> GetAll();
        ICollection<T> GetByIsActive(bool isActive);
    }
}
