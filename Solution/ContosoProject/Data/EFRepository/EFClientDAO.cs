using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Data.EFRepository
{
    public class EFClientDAO: EFBaseDao, IClientRepository
    {
        public EFClientDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Specific query, finds the Clients that mach each not-null parameter
        /// </summary>
        /// <param name="firstName">Client's First Name</param>
        /// <param name="lastName">Client;s Last Name</param>
        /// <param name="city">The city where client lives</param>
        /// <returns>Collection of such clients</returns>
        public ICollection<Client> FindBy(string firstName, string lastName, string city)
        {
            var result = dbContext.Clients.AsQueryable();

            if (!string.IsNullOrWhiteSpace(city))
                result = result.Where(client => client.ClientLocation.City == city);

            if (!string.IsNullOrWhiteSpace(firstName))
                result = result.Where(client => client.Person.FirstName == firstName);

            if (!string.IsNullOrWhiteSpace(lastName))
                result = result.Where(client => client.Person.LastName == lastName);

            return result.ToList();
        }

        public ICollection<Client> GetByDate(DateTime date)
        {
            return dbContext.Clients
               .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
               .ToList();
        }

        #region CRUD
        public void Create(Client entity)
        {
            dbContext.Clients.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Client entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(Client entity)
        {
            dbContext.Clients.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Read(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public Client Read(int id)
        {
            return dbContext.Clients
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Client> GetAll()
        {
            return dbContext.Clients.AsQueryable();
        }

        public IQueryable<Client> GetByIsActive(bool isActive)
        {
            return dbContext.Clients
                .Where(t => t.IsActive == isActive)
                .AsQueryable();
        }

        public IQueryable<Client> FindBy(Expression<Func<Client, bool>> predicate)
        {
            return dbContext.Clients.Where(predicate).AsQueryable();
        } 
        #endregion
    }
}
