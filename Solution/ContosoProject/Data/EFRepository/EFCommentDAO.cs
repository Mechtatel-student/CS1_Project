using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using Domain.Entities.Users;
using System;
using System.Linq.Expressions;

namespace Data.EFRepository
{
    public class EFCommentDAO:EFBaseDao, ICommentRepository
    {
        public EFCommentDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Is Used to get Comments that spicified user made to each kind of entity 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>All these comments</returns>
        public ICollection<Comment> GetAllByUser(User user)
        {
            return dbContext.Set<Comment>()
                .Where(comment => comment.Author == user)
                .ToList();
        }

        #region CRUD
        public ICollection<Comment> GetByDate(DateTime date)
        {
            return dbContext.Comments
               .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
               .ToList();
        }

        public void Create(Comment entity)
        {
            dbContext.Comments.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Comment entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(Comment entity)
        {
            dbContext.Comments.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Read(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public Comment Read(int id)
        {
            return dbContext.Comments
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Comment> GetAll()
        {
            return dbContext.Comments.AsQueryable();
        }

        public IQueryable<Comment> GetByIsActive(bool isActive)
        {
            return dbContext.Comments
                .Where(t => t.IsActive == isActive)
                .AsQueryable();
        }

        public IQueryable<Comment> FindBy(Expression<Func<Comment, bool>> predicate)
        {
            return dbContext.Comments.Where(predicate).AsQueryable();
        }
    } 
        #endregion
}
