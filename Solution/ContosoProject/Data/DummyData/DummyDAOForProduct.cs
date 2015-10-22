using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.DummyData
{
    public class DummyDAOForProduct : DummyDAOExtension<Product>, IProductRepository
    {
        public DummyDAOForProduct()
        {
            _collection = Storage.Products;
        }

        public ICollection<Product> GetBy(string sku, string title, Category category)
        {
            var result = _collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(sku))
            {
                result = result.Where(x => x.SKU == sku);
            }
            if (!string.IsNullOrWhiteSpace(title))
            {
                result = result.Where(x => x.Title ==title);
            }
            if (Category.IsNullOrEmpty(category))
            {
                result = result.Where(x =>x.Category == category);
            }
            return result.ToList();
        }

        public ICollection<Product> GetBySKU(string sku)
        {
            if (_collection.Any(x => x.SKU == sku))
            {
                return _collection.Where(x => x.SKU == sku).ToList();
            }
            throw new Exception();
        }

        public ICollection<Product> GetByCategory(Category category)
        {
            if (_collection.Any(x => x.Category == category))
            {
                return _collection.Where(x => x.Category == category).ToList();
            }
            throw new Exception();
        }
    }
}