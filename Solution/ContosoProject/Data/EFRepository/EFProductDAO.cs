using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Products;
using System;
using System.Linq.Expressions;

namespace Data.EFRepository
{
    public class EFProductDAO:EFBaseDao, IProductRepository
    {
        public EFProductDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// The fuction to get all products that match all not-empty specified datas
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="title"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public ICollection<Product> GetBy(string sku, string title, Category category)
        {
            var result = dbContext.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(sku))
                result = result.Where(product => product.SKU == sku);

            if (!string.IsNullOrWhiteSpace(title))
                result = result.Where(product => product.Title == title);

            if (!Category.IsNullOrEmpty(category))
                result = result.Where(product => product.Category == category);

            return result.ToList();
        }
        /// <summary>
        /// Gets the product with specified SKU
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        public Product GetBySKU(string sku)
        {
            return dbContext.Products
                .FirstOrDefault(product => product.SKU == sku);
        }

        #region CRUD
        public ICollection<Product> GetByDate(DateTime date)
        {
            return dbContext.Products
               .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
               .ToList();
        }

        public void Create(Product entity)
        {
            dbContext.Products.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Product entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(Product entity)
        {
            dbContext.Products.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Read(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public Product Read(int id)
        {
            return dbContext.Products
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetAll()
        {
            return dbContext.Products.AsQueryable();
        }

        public IQueryable<Product> GetByIsActive(bool isActive)
        {
            return dbContext.Products
                .Where(t => t.IsActive == isActive)
                .AsQueryable();
        }

        public IQueryable<Product> FindBy(Expression<Func<Product, bool>> predicate)
        {
            return dbContext.Products.Where(predicate).AsQueryable();
        } 
        #endregion
    }
}
