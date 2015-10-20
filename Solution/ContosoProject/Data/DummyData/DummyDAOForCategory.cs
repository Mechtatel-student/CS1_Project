using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using Data.StoreData;
using System.Text;
using System.Threading.Tasks;   
using Domain.DAO;
using Domain.Entities.Products;
using Microsoft.Win32;

namespace Data.DummyData
{
    class DummyDAOForCategory : DummyDAOExtension<Category>, ICategoryRepository
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
