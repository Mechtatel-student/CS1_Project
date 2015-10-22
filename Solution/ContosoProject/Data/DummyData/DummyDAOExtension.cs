using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    public class DummyDAOExtension<T> : DummyDAO<T>, IRepositoryExtension<T> where T : ExtendedEntity, new()
    {
        public ICollection<T> GetByDate(DateTime date)
        {
            if (_collection.Any(x => String.Equals(x.Date.ToShortDateString(), date.ToShortDateString())))
            {
                return _collection.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).ToList();
            }
            throw new Exception();
        }
    }
}