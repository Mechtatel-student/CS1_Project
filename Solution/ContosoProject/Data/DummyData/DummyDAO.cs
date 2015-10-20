using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Products;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAO<T> : IRepository<T> where T : Entity, new()
    {
        protected IList<T> _collection = new List<T>(); 
        public void Create(T entity)
        {
            if(!(_collection.Any(x => x == entity)))
            _collection.Add(new T());
        }

        public T Find(int id)
        {
            if (!(_collection.Any(x => x.Id == id)))
            {
                return _collection.First(x => x.Id == id);
            }
            throw new Exception();
        }

        public ICollection<T> GetAll()
        {
            return _collection;
        }

        public ICollection<T> GetByIsActive(bool isActive)
        {
            return (ICollection<T>) _collection.Select(x => x.IsActive == isActive).ToList();
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
            throw new Exception();

        }

        public void Delete(int id)
        {
            if (_collection.Any(x => x.Id == id))
            {
                _collection.RemoveAt(id);
            }
            throw new Exception();
        }
    }
}
