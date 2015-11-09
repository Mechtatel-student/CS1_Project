using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;
using System.Data.Entity;
using System;
using System.Linq.Expressions;

namespace Data.EFRepository
{
    public class EFUserDAO: EFBaseDao, IUserRepository
    {
        public EFUserDAO(ProjectContext context)
            : base(context)
        {

        }

        /// <summary>
        /// Function that gets all users that match all not-empty data
        /// </summary>
        /// <param name="login"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public ICollection<User> GetBy(string login, string firstName, string lastName)
        {
            var result = dbContext.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
                result = result.Where(user => user.Login == login);

            if (!string.IsNullOrWhiteSpace(firstName))
                result = result.Where(user => user.Person.FirstName == firstName);

            if (!string.IsNullOrWhiteSpace(lastName))
                result = result.Where(user => user.Person.LastName == lastName);
            return result.Include(user => user.Role).ToList();
        }
        /// <summary>
        /// Gets all users of the specified role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public ICollection<User> GetByRole(Role role)
        {
            return 
                (from user in dbContext.Users
                    where user.Role == role
                        select user)
                            .ToList();
        }

        /// <summary>
        /// Gets the user of specified login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public User Authentificate(string login, string passwordHash)
        {
            return dbContext.Users
                .Include(user => user.Role)
                .Include(user => user.Role.Permissions)
                .FirstOrDefault(user => user.Login == login && user.Password == passwordHash);
        }

        #region CRUD
        public ICollection<User> GetByDate(DateTime date)
        {
            return dbContext.Users
               .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
               .ToList();
        }

        public void Create(User entity)
        {
            dbContext.Users.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(User entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            dbContext.Users.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Read(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public User Read(int id)
        {
            return dbContext.Users
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<User> GetAll()
        {
            return dbContext.Users.Include(user => user.Role).AsQueryable();
        }

        public IQueryable<User> GetByIsActive(bool isActive)
        {
            return dbContext.Users
                .Where(t => t.IsActive == isActive)
                .AsQueryable();
        }

        public IQueryable<User> FindBy(Expression<Func<User, bool>> predicate)
        {
            return dbContext.Users.Where(predicate).AsQueryable();
        } 
        #endregion
    }
}
