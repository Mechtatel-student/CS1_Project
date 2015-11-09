using Domain.Entities;
using Domain.Entities.Users;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data;
using System.Linq;

internal sealed class Configuration : DbMigrationsConfiguration<Data.EFRepository.ProjectContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(Data.EFRepository.ProjectContext context)
    {
        #region Permission
        const string AddUser = "Add User";
        const string EditUser = "Edit User";
        const string SearchUser = "Search User";
        const string ViewUser = "View User";
        const string ActivateUser = "Activate User";
        const string DeactivateUser = "Deactivate User";
        const string CommentUser = "Comment User ";

        const string AddProduct = "Add Product";
        const string EditProduct = "Edit Product";
        const string SearchProduct = "Search Product";
        const string SearchProductByCategory = "Search Product by Category";
        const string ViewProduct = "View Product";
        const string ActivateProduct = "Activate Product";
        const string DeactivateProduct = "Deactivate Product";
        const string CommentProduct = "Comment Product";

        const string AddClient = "Add Client";
        const string EditClient = "Edit Client";
        const string SearchClient = "Search Client";
        const string SearchClientByCity = "Search Client by City";
        const string ViewClient = "View Client";
        const string ActivateClient = "Activate Client";
        const string DeactivateClient = "Deactivate Client";
        const string CommentClient = "Comment Client";

        const string AddCategory = "Add Category";
        const string EditCategory = "Edit Category";
        const string SearchCategory = "Search Category";
        const string ViewCategory = "View Category";
        const string ActivateCategory = "Activate Category";
        const string DeactivateCategory = "Deactivate Category";
        const string CommentCategory = "Comment Category";

        const string AddOrder = "Add Order";
        const string EditOrder = "Edit Order";
        const string SearchOrder = "Search Order";
        const string ViewOrder = "View Order";
        const string ActivateOrder = "Activate Order";
        const string DeactivateOrder = "Deactivate Order";
        const string CommentOrder = "Comment Order";

        const string AddRole = "Add Role";
        const string EditRole = "Edit Role";
        const string ActivateRole = "Activate Role";
        const string DeactivateRole = "Deactivate Role";

        IList<Permission> Permissions = new List<Permission>
        {
            new Permission {Description = "Able to add new user", IsActive = true, Title = AddUser},
            new Permission {Description = "Able to edit existing user’s data", IsActive = true, Title = EditUser},
            new Permission {Description = "Able to search users", IsActive = true, Title = SearchUser},
            new Permission {Description = "Able to view user’s data", IsActive = true, Title = ViewUser},
            new Permission {Description = "Able to activate existing user", IsActive = true, Title = ActivateUser},
            new Permission {Description = "Able to deactivate existing user", IsActive = true, Title = DeactivateUser},
            new Permission {Description = "Able to add comments to existing user", IsActive = true, Title = CommentUser},
            
            new Permission {Description = "Able to add new client", IsActive = true, Title = AddClient},
            new Permission {Description = "Able to edit existing client’s data", IsActive = true, Title = EditClient},
            new Permission {Description = "Able to search clients", IsActive = true, Title = SearchClient},
            new Permission {Description = "Able to search clients by city", IsActive = true, Title = SearchClientByCity},
            new Permission {Description = "Able to view client’s data", IsActive = true, Title = ViewClient},
            new Permission {Description = "Able to activate existing user", IsActive = true, Title = ActivateClient},
            new Permission {Description = "Able to deactivate existing user", IsActive = true, Title = DeactivateClient},
            new Permission {Description = "Able to add comments to existing client", IsActive = true, Title = CommentClient},

            new Permission {Description = "Able to add new product", IsActive = true, Title = AddProduct},
            new Permission {Description = "Able to edit existing product’s data", IsActive = true, Title = EditProduct},
            new Permission {Description = "Able to search products", IsActive = true, Title = SearchProduct},
            new Permission {Description = "Able to search products by category", IsActive = true, Title = SearchProductByCategory},
            new Permission {Description = "Able to view product’s data", IsActive = true, Title = ViewProduct},
            new Permission {Description = "Able to activate existing product", IsActive = true, Title = ActivateProduct},
            new Permission {Description = "Able to deactivate existing product", IsActive = true, Title = DeactivateProduct},
            new Permission {Description = "Able to add comments to existing product", IsActive = true, Title = CommentProduct},

            new Permission {Description = "Able to add new category", IsActive = true, Title = AddCategory},
            new Permission {Description = "Able to edit existing category’s data", IsActive = true, Title = EditCategory},
            new Permission {Description = "Able to search categories", IsActive = true, Title = SearchCategory},
            new Permission {Description = "Able to view category’s data", IsActive = true, Title = ViewCategory},
            new Permission {Description = "Able to activate existing category", IsActive = true, Title = ActivateCategory},
            new Permission {Description = "Able to deactivate existing category", IsActive = true, Title = DeactivateCategory},
            new Permission {Description = "Able to add comments to existing category", IsActive = true, Title = CommentCategory},

            new Permission {Description = "Able to add new order", IsActive = true, Title = AddOrder},
            new Permission {Description = "Able to edit existing order’s data", IsActive = true, Title = EditOrder},
            new Permission {Description = "Able to search orders", IsActive = true, Title = SearchOrder},
            new Permission {Description = "Able to view order’s data",IsActive = true, Title = ViewOrder},
            new Permission {Description = "Able to activate existing order", IsActive = true, Title = ActivateOrder},
            new Permission {Description = "Able to deactivate existing order", IsActive = true, Title = DeactivateOrder},
            new Permission {Description = "Able to add comments to existing order", IsActive = true, Title = CommentOrder},

            new Permission {Description = "Able to add new role", IsActive = true, Title = AddRole},
            new Permission {Description = "Able to edit existing role's data", IsActive = true, Title = EditRole},
            new Permission {Description = "Able to activate existing role", IsActive = true, Title = ActivateRole},
            new Permission {Description = "Able to deactivate existing role", IsActive = true, Title = DeactivateRole}
        }; 
        #endregion
        
        var admin = new User() { Login = "Admin", Password = "queryadmin", IsActive = true,
            Role = new Role { Permissions = Permissions, IsActive = true, Title = "Admin" },
            Person = new Person { FirstName = "Gregory", MiddleName = "Filler", LastName = "Mouse"} };
        if (!context.Users.Any())
            context.Users.Add(admin);
        context.SaveChanges();
    }
}
