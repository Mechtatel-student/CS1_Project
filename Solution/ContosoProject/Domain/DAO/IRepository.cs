using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.DAO
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Save(T entity);
        void Delete(T entity);
        void Delete(int id);
        T Find(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAll();
        IQueryable<T> GetByIsActive(bool isActive);
    }
}
