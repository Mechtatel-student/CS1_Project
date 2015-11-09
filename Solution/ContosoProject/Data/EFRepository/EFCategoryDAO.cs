using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Products;
using System.Linq.Expressions;

namespace Data.EFRepository
{
    public class EFCategoryDAO: EFBaseDao, ICategoryRepository
    {
        public EFCategoryDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Gets all categories, which title maches the entered title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public ICollection<Category> GetByTitle(string title)
        {
            return (from category in dbContext.Categories
                where category.Title == title
                select category)
                .ToList();
        }

        #region CRUD
        /// <summary>
        /// Gets the enities that where added/edited on the specified date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public ICollection<Category> GetByDate(DateTime date)
        {
            return dbContext.Categories
               .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
               .ToList();
        }

        public void Create(Category entity)
        {
            dbContext.Categories.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Category entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(Category entity)
        {
            dbContext.Categories.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Read(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public Category Read(int id)
        {
            return dbContext.Categories
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Category> GetAll()
        {
            return dbContext.Categories.AsQueryable();
        }

        public IQueryable<Category> GetByIsActive(bool isActive)
        {
            return dbContext.Categories
                .Where(t => t.IsActive == isActive)
                .AsQueryable();
        }

        public IQueryable<Category> FindBy(Expression<Func<Category, bool>> predicate)
        {
            return dbContext.Categories.Where(predicate).AsQueryable();
        } 
        #endregion
    }
}
