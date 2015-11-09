using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class EFPermissionDAO: IPermissionRepository
    {
        ProjectContext dbContext;
        /// <summary>
        /// Creates new DAO service on the base of some context
        /// If context is null, creates new Context
        /// </summary>
        /// <param name="context"></param>
        public EFPermissionDAO(ProjectContext context)
        {
            dbContext = context ?? new ProjectContext();
        }
        /// <summary>
        /// Finds the element with specified Id in db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Permission GetById(int id)
        {
            return dbContext.Permissions
                .FirstOrDefault(permission => permission.Id == id);
        }

        /// <summary>
        /// Get all Permissions form db
        /// </summary>
        /// <returns></returns>
        public ICollection<Permission> GetAll()
        {
            return dbContext.Permissions
                    .ToList();
        }
        /// <summary>
        /// Get all permissions that matches specified title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public ICollection<Permission> GetByTitle(string title)
        {
            return (from permission in dbContext.Permissions
                        where permission.Title == title
                            select permission)
                                .ToList();
        }
    }
}
