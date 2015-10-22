using System;
using System.Linq;
using System.Linq.Expressions;
using Domain.DAO;
using Domain.Entities;

namespace Data.EFRepository
{
    public class EFBaseDao<T> : IRepository<T> where T : Entity, new()
    {
        ProjectContext dbContext = new ProjectContext();

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public void Delete(int id)
        {
            var ent = dbContext.Set<T>().FirstOrDefault(x=>x.Id == id);
            dbContext.Set<T>().Remove(ent);
        }

        public T Find(int id)
        {
            return dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> collection = dbContext.Set<T>();
            return collection;
        }

        public IQueryable<T> GetByIsActive(bool isActive)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbContext.Set<T>().Where(predicate);
            return query;
        }
    }
}
