using System.Data.Entity.Migrations;
using Data.EFRepository;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectContext context)
        {

            // seed first user
            var person = new Person() { FirstName = "John", LastName = "Doe", MiddleName = "Anonim" };
            var role = new Role(){Title="test role", IsActive = true};
            var user = new User() { Login = "test", Password = "pass", Person = person, Role = role, IsActive = true };

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
