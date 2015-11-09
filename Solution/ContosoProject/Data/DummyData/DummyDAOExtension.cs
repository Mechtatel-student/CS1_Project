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
            if (Collection.Any(x => x.Date.ToShortDateString() == date.ToShortDateString()))
            {
                return Collection.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).ToList();
            }
            throw new Exception();
        }
    }
}