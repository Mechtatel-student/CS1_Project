using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Users;
using Domain.Entities.Orders;
using Domain.Entities.Products;

namespace Data.StoreData
{
    public static class Storage
    {
        #region Permission's Titles

        private const string AddUser = "Add User";
        private const string EditUser = "Edit User";
        private const string ActivateUser = "Activate User";
        private const string DeactivateUser = "Deactivate User";

        private const string AddProduct = "Add Product";
        private const string EditProduct = "Edit Product";
        private const string ActivateProduct = "Activate Product";
        private const string DeactivateProduct = "Deactivate Product";

        private const string AddClient = "Add Client";
        private const string EditClient = "Edit Client";

        private const string AddComment = "Add Comment";
        private const string EditComment = "Edit Comment";

        private const string AddOrder = "Add Order";
        private const string EditOrder = "Edit Order";
        private const string ActivateOrder = "Activate Order";
        private const string DeactivateOrder = "Deactivate Order";

        #endregion

        #region Permissions

        public static PermissionDictionary Permissions = new PermissionDictionary
        {
            new Permission {Description = "", Id = 1, IsActive = true, Title = AddUser},
            new Permission {Description = "", Id = 2, IsActive = true, Title = EditUser},
            new Permission {Description = "", Id = 3, IsActive = true, Title = ActivateUser},
            new Permission {Description = "", Id = 4, IsActive = true, Title = DeactivateUser},

            new Permission {Description = "", Id = 5, IsActive = true, Title = AddProduct},
            new Permission {Description = "", Id = 6, IsActive = true, Title = EditProduct},
            new Permission {Description = "", Id = 7, IsActive = true, Title = ActivateProduct},
            new Permission {Description = "", Id = 8, IsActive = true, Title = DeactivateProduct},

            new Permission {Description = "", Id = 9, IsActive = true, Title = AddClient},
            new Permission {Description = "", Id = 10, IsActive = true, Title = EditClient},

            new Permission {Description = "", Id = 11, IsActive = true, Title = AddComment},
            new Permission {Description = "", Id = 12, IsActive = true, Title = EditComment},

            new Permission {Description = "", Id = 13, IsActive = true, Title = AddOrder},
            new Permission {Description = "", Id = 14, IsActive = true, Title = EditOrder},
            new Permission {Description = "", Id = 15, IsActive = true, Title = ActivateOrder},
            new Permission {Description = "", Id = 16, IsActive = true, Title = DeactivateOrder}
        };

        public static List<Permission> AdminPermissions = new List<Permission>
        {
            Permissions[AddUser],
            Permissions[EditUser],
            Permissions[ActivateUser],
            Permissions[DeactivateUser],
            Permissions[AddProduct],
            Permissions[EditProduct],
            Permissions[ActivateProduct],
            Permissions[DeactivateProduct],
            Permissions[AddClient],
            Permissions[EditClient],
            Permissions[AddComment],
            Permissions[EditComment],
            Permissions[AddOrder],
            Permissions[EditOrder],
            Permissions[ActivateOrder],
            Permissions[DeactivateOrder]
        };

        public static List<Permission> DirectorPermissions = new List<Permission>
        {
            Permissions[AddProduct],
            Permissions[EditProduct],
            Permissions[ActivateProduct],
            Permissions[DeactivateProduct],
            Permissions[AddClient],
            Permissions[EditClient],
            Permissions[AddComment],
            Permissions[EditComment],
            Permissions[AddOrder],
            Permissions[EditOrder],
            Permissions[ActivateOrder],
            Permissions[DeactivateOrder]
        };

        public static List<Permission> ManagerPermissions = new List<Permission>
        {
            Permissions[AddClient],
            Permissions[EditClient],
            Permissions[AddComment],
            Permissions[EditComment],
            Permissions[AddOrder],
            Permissions[EditOrder],
            Permissions[ActivateOrder],
            Permissions[DeactivateOrder]
        };

        #endregion

        #region Personal Info

        public static List<Comment> GodComments = new List<Comment>
        {
            new Comment{Text = "The best man ever",                                 EntityType = EntityType.User, Id = 1, IsActive = true, Date = DateTime.Now.AddDays(-1)},
            new Comment{Text = "Good guy, you can believe him in any case",         EntityType = EntityType.User, Id = 2, IsActive = true, Date = DateTime.Now.AddDays(-1)},
            new Comment{Text = "Don't Troube him too much, he doesn't like this",   EntityType = EntityType.User, Id = 3, IsActive = true, Date = DateTime.Now.AddDays(-3)},
            new Comment{Text = "Gon't try to kick him",                             EntityType = EntityType.User, Id = 4, IsActive = true, Date = DateTime.Now.AddDays(-30)}
        };

        public static RoleDictionary Roles = new RoleDictionary
        {
            new Role(AdminPermissions)      {Id = 1, IsActive = true, Title = "Admin"},
            new Role(ManagerPermissions)    {Id = 2, IsActive = true, Title = "Manager"},
            new Role(DirectorPermissions)   {Id = 3, IsActive = true, Title = "Director"}
        };

        public static List<Location> Locations = new List<Location>
        {
            new Location {Adress = "pr. Metalurgov, 78", City = "Dnepropetrovsk"},
            new Location {Adress = "ul. Sevastopolskaya, 43", City = "Dnepropetrovsk"},
            new Location {Adress = "ul. Davidova, 3", City = "Dnepropetrovsk"},
            new Location {Adress = "ul. Gogolya, 6", City = "Dnepropetrovsk"}
        };

        public static List<List<string>> ClientTelephones = new List<List<string>>
        {
            new List<string> {"+389264093268", "+389261000000"},
            new List<string> {"+389261000000", "+389263465914"},
            new List<string>()
        };

        public static List<Person> Persons = new List<Person>
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
        
        public static List<User> Users = new List<User>
        {
            new User(GodComments)         {Date = DateTime.Now.AddDays(-5), Role = Roles[0], Id = 1, IsActive = true,   Login = "God",                  Password = "safe342g",      Person = Persons[0]},
            new User(new List<Comment>()) {Date = DateTime.Now.AddDays(-6), Role = Roles[0], Id = 2, IsActive = true,   Login = "FirstSimpleAdmin",     Password = "adm123in",      Person = Persons[1]},
            new User(new List<Comment>()) {Date = DateTime.Now.AddDays(-6), Role = Roles[0], Id = 3, IsActive = false,  Login = "SecondSimpleAdmin",    Password = "min43ad",       Person = Persons[2]},
            new User(new List<Comment>()) {Date = DateTime.Now.AddDays(-8), Role = Roles[1], Id = 4, IsActive = true,   Login = "ActiveManager",        Password = "manageR323",    Person = Persons[3]},
            new User(new List<Comment>()) {Date = DateTime.Now.AddDays(-9), Role = Roles[2], Id = 5, IsActive = true,   Login = "Dir",                  Password = "dry;78s",       Person = Persons[4]},
            new User(new List<Comment>()) {Date = DateTime.Now.AddDays(-9), Role = Roles[1], Id = 6, IsActive = true,   Login = "Man13",                Password = "mind45",        Person = Persons[5]}
        };

        public static List<Client> Clients = new List<Client>
        {
            new Client(ClientTelephones[0], new List<Comment>()){ClientLocation = Locations[0], Id = 1, IsActive = true, Date = DateTime.Now.AddHours(-5), Person = Persons[6]},
            new Client(ClientTelephones[2], new List<Comment>()){ClientLocation = Locations[1], Id = 2, IsActive = true, Date = DateTime.Now.AddHours(-8), Person = Persons[7]},
            new Client(ClientTelephones[1], new List<Comment>()){ClientLocation = Locations[3], Id = 3, IsActive = true, Date = DateTime.Now.AddHours(-9), Person = Persons[8]}
        };

        public static CategoryDictionary Categories = new CategoryDictionary
        {
            new Category(new List<Comment>()){Id = 1, IsActive = true,  Title = "Wooden",   Date = DateTime.Now.AddDays(-20)},
            new Category(new List<Comment>()){Id = 2, IsActive = false, Title = "Modern",   Date = DateTime.Now.AddDays(-10)},
            new Category(new List<Comment>()){Id = 3, IsActive = true,  Title = "Metal",    Date = DateTime.Now.AddDays(-15)}
        };

        public static List<Product> Products = new List<Product>
        {
            new Product(new List<Comment>()){Category = Categories[0], Id = 1, IsActive = true,     Title = "Table",    Price = 100,    Date = DateTime.Now, SKU = "jh423b"},
            new Product(new List<Comment>()){Category = Categories[1], Id = 2, IsActive = true,     Title = "Chair",    Price = 60,     Date = DateTime.Now, SKU = "sfdfh3"},
            new Product(new List<Comment>()){Category = Categories[0], Id = 3, IsActive = true,     Title = "Wardrobe", Price = 20,     Date = DateTime.Now, SKU = "fhk32x"},
            new Product(new List<Comment>()){Category = Categories[2], Id = 4, IsActive = false,    Title = "Table",    Price = 200,    Date = DateTime.Now, SKU = "jh423b"},
            new Product(new List<Comment>()){Category = Categories[1], Id = 5, IsActive = true,     Title = "ArmChair", Price = 30,     Date = DateTime.Now, SKU = "lkj34q"}
        };

        public static List<List<OrderItem>> OrderItems = new List<List<OrderItem>>
        {
            new List<OrderItem>{new OrderItem(Products[0], 2, 120), new OrderItem(Products[1], 2, 200), new OrderItem(Products[3], 3, 60), new OrderItem(Products[4], 2, 100)},
            new List<OrderItem>{new OrderItem(Products[0], 2, 230), new OrderItem(Products[3], 1, 400)},
            new List<OrderItem>{new OrderItem(Products[4], 1, 80)},
            new List<OrderItem>()
        };

        public static List<Order> Orders = new List<Order>
         {
             new Order(new List<Comment>(), OrderItems[0]){Client = Clients[0], Id = 1, IsActive = true, Status = Status.Opened, Date = DateTime.Today.AddDays(-1)},
             new Order(new List<Comment>(), OrderItems[1]){Client = Clients[2], Id = 2, IsActive = true, Status = Status.Closed, Date = DateTime.Today.AddDays(-5)},
             new Order(new List<Comment>(), OrderItems[2]){Client = Clients[1], Id = 3, IsActive = true, Status = Status.Opened, Date = DateTime.Today.AddDays(-3)},
             new Order(new List<Comment>(), OrderItems[3]){Client = Clients[2], Id = 4, IsActive = true, Status = Status.PaidUp, Date = DateTime.Today.AddDays(-40)}
         };
    }
}
