using System.Data.Entity;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;
using System.Collections.Generic;
using Domain.Entities.Clients;
using Domain.Entities.Comments;

namespace Data.EFRepository
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectContext, Configuration>("ProjectContext"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Order>()
            //    .HasMany<OrderItem>(order => order.OrderItems)
            //    .WithRequired(orderItem => orderItem.Order)
            //    .HasForeignKey(orderItem => orderItem.OrderId)
            //    .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Permission> Permissions { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
