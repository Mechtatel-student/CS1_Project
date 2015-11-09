using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Users;
using System.Linq.Expressions;

namespace Data.EFRepository
{
    public class EFRoleDAO:EFBaseDao, IRoleRepository
    {
        public EFRoleDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Gets specified Role by its title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public ICollection<Role> GetByTitle(string title)
        {
            return (from role in dbContext.Set<Role>()
                        where role.Title == title
                            select role)
                            .ToList();
        }
        /// <summary>
        /// Get's All roles, that have got such a permission
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public ICollection<Role> GetByPermission(Permission permission)
        {
            return (from user in dbContext.Users 
                        where user.Role.Permissions.Contains(permission)
                            select user.Role)
                            .Distinct()
                            .ToList();
        }

        #region CRUD
        public void Create(Role entity)
        {
            dbContext.Roles.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Role entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(Role entity)
        {
            dbContext.Roles.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Read(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public Role Read(int id)
        {
            return dbContext.Roles
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Role> GetAll()
        {
            return dbContext.Roles.AsQueryable();
        }

        public IQueryable<Role> GetByIsActive(bool isActive)
        {
            return dbContext.Roles
                .Where(t => t.IsActive == isActive)
                .AsQueryable();
        }

        public IQueryable<Role> FindBy(Expression<Func<Role, bool>> predicate)
        {
            return dbContext.Roles.Where(predicate).AsQueryable();
        } 
        #endregion
    }
}
