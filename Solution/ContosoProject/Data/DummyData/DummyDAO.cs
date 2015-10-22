
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    public class DummyDAO<T> : IRepository<T> where T : Entity, new()
    {
        protected IList<T> _collection = new List<T>();

        public void Create(T entity)
        {
            if (!(_collection.Any(x => x == entity)))
                _collection.Add(entity);
            else
                throw new Exception();
        }

        public T Find(int id)
        {
            if (_collection.Any(x => x.Id == id))
            {
                return _collection.First(x => x.Id == id);
            }
            else
                throw new Exception();
        }

        public IQueryable<T> GetAll()
        {
            return _collection.AsQueryable<T>();
        }

        public IQueryable<T> GetByIsActive(bool isActive)
        {
            return _collection.Where(x => x.IsActive == isActive).AsQueryable<T>();
        }

        public void Save(T entity)
        {
            T oldEntity = _collection.First(x => x.Id == entity.Id);
            oldEntity.Id = entity.Id;
            oldEntity.IsActive = entity.IsActive;
        }

        public void Delete(T entity)
        {
            if (_collection.Any(x => x == entity))
            {
                _collection.First(x => x == entity).IsActive = false;
            }
            else
                throw new Exception();

        }

        public void Delete(int id)
        {
            if (_collection.Any(x => x.Id == id))
            {
                _collection.First(x => x.Id == id).IsActive = false;
            }
            else
                throw new Exception();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}