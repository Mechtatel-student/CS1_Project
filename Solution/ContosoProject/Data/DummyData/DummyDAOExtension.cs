﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAOExtension<T> : DummyDAO<T>, IRepositoryExtension<T> where T : ExtendedEntity, new()
    {
        public ICollection<T> GetByUser(User user)
        {
            if (_collection.Any(x => x.User == user))
            {
                return (ICollection<T>)_collection.Select(x => x.User).ToList();
            }
            throw new Exception();
        }

        public ICollection<T> GetByDate(DateTime date)
        {
            if (_collection.Any(x => String.Equals(x.Date.ToShortDateString(), date.ToShortDateString())))
            {
                return _collection.Where(x => String.Equals(x.Date.ToShortDateString(), date.ToShortDateString())).ToList();
            }
            throw new Exception();
        }
    }
}