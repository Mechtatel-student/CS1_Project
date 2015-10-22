using System;
using System.Collections.Generic;
using Domain.Entities.Comments;
using Domain.Entities.Products;

namespace Data.StoreData
{
    public static partial class Storage
    {
        public static CategoryDictionary Categories = new CategoryDictionary
        {
            new Category(new List<Comment>()){Id = 1, IsActive = true, Title = "Wooden", Date = new DateTime(2001, 8, 12)},
            new Category(new List<Comment>()){Id = 2, IsActive = false, Title = "Modern", Date = new DateTime(2002, 7, 11)},
            new Category(new List<Comment>()){Id = 3, IsActive = true, Title = "Metal", Date = new DateTime(2001, 8, 11)}
        };

        public static List<Product> Products = new List<Product>
        {
            new Product(new List<Comment>()){Category = Categories["Wooden"], Id = 1, IsActive = true, Title = "Table", Price = 100, Date = new DateTime(2003, 5, 6, 12, 5 ,2), User = Users[0], SKU = "jh423b"},
            new Product(new List<Comment>()){Category = Categories["Modern"], Id = 2, IsActive = true, Title = "Chair", Price = 60, Date = new DateTime(2003, 5, 6, 12, 5 ,15), User = Users[3], SKU = "sfdfh3"},
            new Product(new List<Comment>()){Category = Categories["Wooden"], Id = 3, IsActive = true, Title = "Wardrobe", Price = 20, Date = new DateTime(2003, 5, 6, 12, 6 ,6), User = Users[0], SKU = "fhk32x"},
            new Product(new List<Comment>()){Category = Categories["Metal"], Id = 4, IsActive = false, Title = "Table", Price = 200, Date = new DateTime(2003, 5, 6, 52, 2 ,3), User = Users[3], SKU = "jh423b"},
            new Product(new List<Comment>()){Category = Categories["Modern"], Id = 5, IsActive = true, Title = "ArmChair", Price = 30, Date = new DateTime(2003, 5, 6,44, 1 ,32), User = Users[2], SKU = "lkj34q"}
        }; 
    }
}
