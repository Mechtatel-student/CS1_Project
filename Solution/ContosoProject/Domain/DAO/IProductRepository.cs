using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Products;

namespace Domain.DAO
{
    public interface IProductRepository : IRepositoryExtension<Product>
    {
        ICollection<Product> GetBy(string sku, string title, Category category);
        ICollection<Product> GetBySKU(string sku);
        ICollection<Product> GetByCategory(Category category);
    }
}