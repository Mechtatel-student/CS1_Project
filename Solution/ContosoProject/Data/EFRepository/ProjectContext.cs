using System.Data.Entity;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ProjectContext>());
        }

        public DbSet<Order> Oders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
