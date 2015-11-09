using System;
using System.Collections.Generic;
using System.ComponentModel;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Domain.Entities.Clients;

namespace Data.StoreData
{
    public static class Storage
    {
        #region Permission's Titles

        private const string AddUser = "Add User";
        private const string EditUser = "Edit User";
        private const string SearchUser = "Search User";
        private const string ViewUser = "View User";
        private const string ActivateUser = "Activate User";
        private const string DeactivateUser = "Deactivate User";
        private const string CommentUser = "Comment User ";

        private const string AddProduct = "Add Product";
        private const string EditProduct = "Edit Product";
        private const string SearchProduct = "Search Product";
        private const string SearchProductByCategory = "Search Client by Product";
        private const string ViewProduct = "View Product";
        private const string ActivateProduct = "Activate Product";
        private const string DeactivateProduct = "Deactivate Product";
        private const string CommentProduct = "Comment Product";

        private const string AddClient = "Add Client";
        private const string EditClient = "Edit Client";
        private const string SearchClient = "Search Client";
        private const string SearchClientByCity = "Search Client by City";
        private const string ViewClient = "View Client";
        private const string ActivateClient = "Activate Client";
        private const string DeactivateClient = "Deactivate Client";
        private const string CommentClient = "Comment Client";

        private const string AddCategory = "Add Category";
        private const string EditCategory = "Edit Category";
        private const string SearchCategory = "Search Category";
        private const string ViewCategory = "View Category";
        private const string ActivateCategory = "Activate Category";
        private const string DeactivateCategory = "Deactivate Category";
        private const string CommentCategory = "Comment Category";

        private const string AddOrder = "Add Order";
        private const string EditOrder = "Edit Order";
        private const string SearchOrder = "Search Order";
        private const string ViewOrder = "View Order";
        private const string ActivateOrder = "Activate Order";
        private const string DeactivateOrder = "Deactivate Order";
        private const string CommentOrder = "Comment Order";
        #endregion

        #region Permissions

        public static IList<Permission> Permissions = new List<Permission>
        {
            new Permission {Description = "Able to add new user", Id = 1, IsActive = true, Title = AddUser},
            new Permission {Description = "Able to edit existing user’s data", Id = 2, IsActive = true, Title = EditUser},
            new Permission {Description = "Able to search users", Id = 3, IsActive = true, Title = SearchUser},
            new Permission {Description = "Able to view user’s data", Id = 4, IsActive = true, Title = ViewUser},
            new Permission {Description = "Able to activate existing user", Id = 5, IsActive = true, Title = ActivateUser},
            new Permission {Description = "Able to deactivate existing user", Id = 6, IsActive = true, Title = DeactivateUser},
            new Permission {Description = "Able to add comments to existing user", Id = 7, IsActive = true, Title = CommentUser},
            
            new Permission {Description = "Able to add new client", Id = 9, IsActive = true, Title = AddClient},
            new Permission {Description = "Able to edit existing client’s data", Id = 10, IsActive = true, Title = EditClient},
            new Permission {Description = "Able to search clients", Id = 11 , IsActive = true, Title = SearchClient},
            new Permission {Description = "Able to search clients by city", Id = 12, IsActive = true, Title = SearchClientByCity},
            new Permission {Description = "Able to view client’s data", Id = 13, IsActive = true, Title = ViewClient},
            new Permission {Description = "Able to activate existing user", Id = 14, IsActive = true, Title = ActivateClient},
            new Permission {Description = "Able to deactivate existing user", Id = 15, IsActive = true, Title = DeactivateClient},
            new Permission {Description = "Able to add comments to existing client", Id = 16, IsActive = true, Title = CommentClient},

            new Permission {Description = "Able to add new product", Id = 17, IsActive = true, Title = AddProduct},
            new Permission {Description = "Able to edit existing product’s data", Id = 18, IsActive = true, Title = EditProduct},
            new Permission {Description = "Able to search products", Id = 19, IsActive = true, Title = SearchProduct},
            new Permission {Description = "Able to search products by category", Id = 20, IsActive = true, Title = SearchProductByCategory},
            new Permission {Description = "Able to view product’s data", Id = 21, IsActive = true, Title = ViewProduct},
            new Permission {Description = "Able to activate existing product", Id = 22, IsActive = true, Title = ActivateProduct},
            new Permission {Description = "Able to deactivate existing product", Id = 23, IsActive = true, Title = DeactivateProduct},
            new Permission {Description = "Able to add comments to existing product", Id = 24, IsActive = true, Title = CommentProduct},

            new Permission {Description = "Able to add new category", Id = 25, IsActive = true, Title = AddCategory},
            new Permission {Description = "Able to edit existing category’s data", Id = 26, IsActive = true, Title = EditCategory},
            new Permission {Description = "Able to search categories", Id = 27, IsActive = true, Title = SearchCategory},
            new Permission {Description = "Able to view category’s data", Id = 28, IsActive = true, Title = ViewCategory},
            new Permission {Description = "Able to activate existing category", Id = 29, IsActive = true, Title = ActivateCategory},
            new Permission {Description = "Able to deactivate existing category", Id = 30, IsActive = true, Title = DeactivateCategory},
            new Permission {Description = "Able to add comments to existing category", Id = 31, IsActive = true, Title = CommentCategory},

            new Permission {Description = "Able to add new order", Id = 32, IsActive = true, Title = AddOrder},
            new Permission {Description = "Able to edit existing order’s data", Id = 33, IsActive = true, Title = EditOrder},
            new Permission {Description = "Able to search orders", Id = 34, IsActive = true, Title = SearchOrder},
            new Permission {Description = "Able to view order’s data", Id = 35, IsActive = true, Title = ViewOrder},
            new Permission {Description = "Able to activate existing order", Id = 36, IsActive = true, Title = ActivateOrder},
            new Permission {Description = "Able to deactivate existing order", Id = 37, IsActive = true, Title = DeactivateOrder},
            new Permission {Description = "Able to add comments to existing order", Id = 38, IsActive = true, Title = CommentOrder}
        };

        public static IList<Permission> AdminPermissions = new List<Permission>(Permissions);

        public static IList<Permission> DirectorPermissions = new List<Permission>
        {
            Permissions[2],
            Permissions[3],
            Permissions[7],
            Permissions[8],
            Permissions[9],
            Permissions[10],
            Permissions[11],
            Permissions[12],
            Permissions[13],
            Permissions[14],
            Permissions[15],
            Permissions[16],
            Permissions[17],
            Permissions[18],
            Permissions[19],
            Permissions[20],
            Permissions[21],
            Permissions[22],
            Permissions[23],
            Permissions[24],
            Permissions[25],
            Permissions[26],
            Permissions[27],
            Permissions[28],
            Permissions[29],
            Permissions[30],
            Permissions[31],
            Permissions[32],
            Permissions[33],
            Permissions[34],
            Permissions[35],
            Permissions[36]
        };

        public static IList<Permission> ManagerPermissions = new List<Permission>
        {
            Permissions[2],
            Permissions[3],
            Permissions[7],
            Permissions[8],
            Permissions[9],
            Permissions[11],
            Permissions[12],
            Permissions[13],
            Permissions[14],
            Permissions[15],
            Permissions[16],
            Permissions[17],
            Permissions[19],
            Permissions[20],
            Permissions[21],
            Permissions[22],
            Permissions[23],
            Permissions[24],
            Permissions[25],
            Permissions[26],
            Permissions[27],
            Permissions[28],
            Permissions[29],
            Permissions[30],
            Permissions[31],
            Permissions[32],
            Permissions[33],
            Permissions[34],
            Permissions[35],
            Permissions[36]
        };

        #endregion

        #region Personal Info

        public static IList<Comment> GodComments = new List<Comment>
        {
            new Comment{Text = "The best man ever",                                 EntityType = EntityType.User, Id = 1, IsActive = true, Date = DateTime.Now.AddDays(-1)},
            new Comment{Text = "Good guy, you can believe him in any case",         EntityType = EntityType.User, Id = 2, IsActive = true, Date = DateTime.Now.AddDays(-1)},
            new Comment{Text = "Don't Troube him too much, he doesn't like this",   EntityType = EntityType.User, Id = 3, IsActive = true, Date = DateTime.Now.AddDays(-3)},
            new Comment{Text = "Gon't try to kick him",                             EntityType = EntityType.User, Id = 4, IsActive = true, Date = DateTime.Now.AddDays(-30)}
        };

        public static IList<Role> Roles = new List<Role>
        {
            new Role(AdminPermissions)      {Id = 1, IsActive = true, Title = "Admin"},
            new Role(ManagerPermissions)    {Id = 2, IsActive = true, Title = "Manager"},
            new Role(DirectorPermissions)   {Id = 3, IsActive = true, Title = "Director"}
        };

        public static IList<Location> Locations = new List<Location>
        {
            new Location {Address = "pr. Metalurgov, 78", City = "Dnepropetrovsk"},
            new Location {Address = "ul. Sevastopolskaya, 43", City = "Dnepropetrovsk"},
            new Location {Address = "ul. Davidova, 3", City = "Dnepropetrovsk"},
            new Location {Address = "ul. Gogolya, 6", City = "Dnepropetrovsk"}
        };

        public static IList<List<Telephone>> ClientTelephones = new List<List<Telephone>>
        {
            new List<Telephone> {new Telephone{Number = "+389264093268"},new Telephone{Number =  "+389261000000"}},
            new List<Telephone> {new Telephone{Number = "+389261000000"},new Telephone{Number =  "+389263465914"}},
            new List<Telephone>()
        };

        public static IList<Person> Persons = new List<Person>
        {
            new Person {FirstName = "Greg", MiddleName = "Kollins", LastName = "House"},
            new Person {FirstName = "Taisha", MiddleName = "Lewis", LastName = "Carrol"},
            new Person {FirstName = "Denni", MiddleName = "Winston", LastName = "Marconi"},
            new Person {FirstName = "Kolli", MiddleName = "Leron", LastName = "Ostinger"},
            new Person {FirstName = "Climon", MiddleName = "Tomas", LastName = "Lerman"},
            new Person {FirstName = "Locus", MiddleName = "Stew", LastName = "Okernel"},
            new Person {FirstName = "Nik", MiddleName = "Markus", LastName = "Flemigan"},
            new Person {FirstName = "Serge", MiddleName = "Petros", LastName = "Morgan"},
            new Person {FirstName = "Morgan", MiddleName = "Lukas", LastName = "Plemon"}
        };

        #endregion

        public static IList<User> Users = new List<User>
        {
            new User() {Date = DateTime.Now.AddDays(-5), Role = Roles[0], Id = 1, IsActive = true,   Login = "God",                  Password = "safe342g",      Person = Persons[0]},
            new User() {Date = DateTime.Now.AddDays(-6), Role = Roles[0], Id = 2, IsActive = true,   Login = "FirstSimpleAdmin",     Password = "adm123in",      Person = Persons[1]},
            new User() {Date = DateTime.Now.AddDays(-6), Role = Roles[0], Id = 3, IsActive = false,  Login = "SecondSimpleAdmin",    Password = "min43ad",       Person = Persons[2]},
            new User() {Date = DateTime.Now.AddDays(-8), Role = Roles[1], Id = 4, IsActive = true,   Login = "ActiveManager",        Password = "manageR323",    Person = Persons[3]},
            new User() {Date = DateTime.Now.AddDays(-9), Role = Roles[2], Id = 5, IsActive = true,   Login = "Dir",                  Password = "dry;78s",       Person = Persons[4]},
            new User() {Date = DateTime.Now.AddDays(-9), Role = Roles[1], Id = 6, IsActive = true,   Login = "Man13",                Password = "mind45",        Person = Persons[5]},
            new User() {Date = DateTime.Now.AddDays(-5), Role = Roles[1], Id = 1, IsActive = true,   Login = "m",                    Password = "11",            Person = Persons[0]},
            new User() {Date = DateTime.Now.AddDays(-5), Role = Roles[2], Id = 1, IsActive = true,   Login = "d",                    Password = "11",            Person = Persons[0]}

        };

        public static IList<Client> Clients = new List<Client>
        {
            new Client(ClientTelephones[0], new List<Comment>()){ClientLocation = Locations[0], Id = 1, IsActive = true, Date = DateTime.Now.AddHours(-5), Person = Persons[6]},
            new Client(ClientTelephones[1], new List<Comment>()){ClientLocation = Locations[1], Id = 2, IsActive = true, Date = DateTime.Now.AddHours(-8), Person = Persons[7]},
            new Client(ClientTelephones[2], new List<Comment>()){ClientLocation = Locations[3], Id = 3, IsActive = true, Date = DateTime.Now.AddHours(-9), Person = Persons[8]}
        };

        public static IList<Category> Categories = new List<Category>
        {
            new Category(){Id = 1, IsActive = true,  Title = "Wooden",   Date = DateTime.Now.AddDays(-20)},
            new Category(){Id = 2, IsActive = false, Title = "Modern",   Date = DateTime.Now.AddDays(-10)},
            new Category(){Id = 3, IsActive = true,  Title = "Metal",    Date = DateTime.Now.AddDays(-15)}
        };

        public static IList<Product> Products = new List<Product>
        {
            new Product(){Category = Categories[0], Id = 1, IsActive = true,     Title = "Table",    Price = 100,    Date = DateTime.Now, SKU = "jh423b", Quantity = 1},
            new Product(){Category = Categories[1], Id = 2, IsActive = true,     Title = "Chair",    Price = 60,     Date = DateTime.Now, SKU = "sfdfh3", Quantity = 0},
            new Product(){Category = Categories[0], Id = 3, IsActive = true,     Title = "Wardrobe", Price = 20,     Date = DateTime.Now, SKU = "fhk32x", Quantity = 3},
            new Product(){Category = Categories[2], Id = 4, IsActive = false,    Title = "Table",    Price = 200,    Date = DateTime.Now, SKU = "giru2f", Quantity = 2},
            new Product(){Category = Categories[1], Id = 5, IsActive = true,     Title = "ArmChair", Price = 30,     Date = DateTime.Now, SKU = "lkj34q", Quantity = 4}
        };

        public static List<List<OrderItem>> OrderItems = new List<List<OrderItem>>
        {
            new List<OrderItem>{new OrderItem(Products[0], 2, 120), new OrderItem(Products[1], 2, 200), new OrderItem(Products[3], 3, 60), new OrderItem(Products[4], 2, 100)},
            new List<OrderItem>{new OrderItem(Products[0], 2, 230), new OrderItem(Products[3], 1, 400)},
            new List<OrderItem>{new OrderItem(Products[4], 1, 80)},
            new List<OrderItem>()
        };

        public static IList<Order> Orders = new List<Order>
         {
             new Order(new List<Comment>(), OrderItems[0]){Client = Clients[0], Id = 1, IsActive = true, Status = Status.Opened, Date = DateTime.Today.AddDays(-1)},
             new Order(new List<Comment>(), OrderItems[1]){Client = Clients[2], Id = 2, IsActive = true, Status = Status.Closed, Date = DateTime.Today.AddDays(-5)},
             new Order(new List<Comment>(), OrderItems[2]){Client = Clients[1], Id = 3, IsActive = true, Status = Status.Opened, Date = DateTime.Today.AddDays(-3)},
             new Order(new List<Comment>(), OrderItems[3]){Client = Clients[2], Id = 4, IsActive = true, Status = Status.PaidUp, Date = DateTime.Today.AddDays(-40)}
         };
    }
}
