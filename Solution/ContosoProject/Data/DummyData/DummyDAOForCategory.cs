﻿using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.DummyData
{
    public class DummyDAOForCategory : DummyDAOExtension<Category>, ICategoryRepository
    {
        public DummyDAOForCategory()
        {
            _collection = Storage.Categories;
        }

        public ICollection<Category> GetByTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                return _collection.Where(x=>x.Title==title).ToList();
            }
            throw new Exception();
        }
    }
}