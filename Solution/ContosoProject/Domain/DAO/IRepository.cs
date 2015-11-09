using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.DAO
{
    public interface IRepository<T>
    {
        void Create(T entity);
        T Read(int id);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);

        IQueryable<T> GetAll();
        IQueryable<T> GetByIsActive(bool isActive);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
    }
}
