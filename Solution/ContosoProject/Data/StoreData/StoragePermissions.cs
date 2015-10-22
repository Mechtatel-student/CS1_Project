using System.Collections.Generic;
using Domain.Entities.Users;

namespace Data.StoreData
{
    public static partial class Storage
    {
        #region Permissions

        public static PermissionDictionary Permissions = new PermissionDictionary
        {
            new Permission {Description = "", Id = 1, IsActive = true, Title = "Add User"},
            new Permission {Description = "", Id = 2, IsActive = true, Title = "Edit User"},
            new Permission {Description = "", Id = 3, IsActive = true, Title = "Activate User"},
            new Permission {Description = "", Id = 4, IsActive = true, Title = "Deactivate User"},

            new Permission {Description = "", Id = 5, IsActive = true, Title = "Add Product"},
            new Permission {Description = "", Id = 6, IsActive = true, Title = "Edit Product"},
            new Permission {Description = "", Id = 7, IsActive = true, Title = "Activate Product"},
            new Permission {Description = "", Id = 8, IsActive = true, Title = "Deactivate Product"},

            new Permission {Description = "", Id = 9, IsActive = true, Title = "Add Client"},
            new Permission {Description = "", Id = 10, IsActive = true, Title = "Edit Client"},

            new Permission {Description = "", Id = 11, IsActive = true, Title = "Add Comment"},
            new Permission {Description = "", Id = 12, IsActive = true, Title = "Edit Comment"},

            new Permission {Description = "", Id = 13, IsActive = true, Title = "Add Order"},
            new Permission {Description = "", Id = 14, IsActive = true, Title = "Edit Order"},
            new Permission {Description = "", Id = 15, IsActive = true, Title = "Activate Order"},
            new Permission {Description = "", Id = 16, IsActive = true, Title = "Deactivate Order"}
        };

        public static List<Permission> AdminPermissions = new List<Permission>
        {
            Permissions["Add User"],
            Permissions["Edit User"],
            Permissions["Activate User"],
            Permissions["Deactivate User"],
            Permissions["Add Product"],
            Permissions["Edit Product"],
            Permissions["Activate Product"],
            Permissions["Deactivate Product"],
            Permissions["Add Client"],
            Permissions["Edit Client"],
            Permissions["Add Comment"],
            Permissions["Edit Comment"],
            Permissions["Add Order"],
            Permissions["Edit Order"],
            Permissions["Activate Order"],
            Permissions["Deactivate order"]
        };

        public static List<Permission> DirectorPermissions = new List<Permission>
        {
            Permissions["Add Product"],
            Permissions["Edit Product"],
            Permissions["Activate Product"],
            Permissions["Deactivate Product"],
            Permissions["Add Client"],
            Permissions["Edit Client"],
            Permissions["Add Comment"],
            Permissions["Edit Comment"],
            Permissions["Add Order"],
            Permissions["Edit Order"],
            Permissions["Activate Order"],
            Permissions["Deactivate order"]
        };

        public static List<Permission> ManagerPermissions = new List<Permission>
        {
            Permissions["Add Client"],
            Permissions["Edit Client"],
            Permissions["Add Comment"],
            Permissions["Edit Comment"],
            Permissions["Add Order"],
            Permissions["Edit Order"],
            Permissions["Activate Order"],
            Permissions["Deactivate order"]
        };

        #endregion

        public static RoleDictionary Roles = new RoleDictionary
        {
            new Role(AdminPermissions){Id = 1, IsActive = true, Title = "Admin"},
            new Role(ManagerPermissions){Id = 2, IsActive = true, Title = "Manager"},
            new Role(DirectorPermissions){Id = 3, IsActive = true, Title = "Director"}
        }; 
    }
}
