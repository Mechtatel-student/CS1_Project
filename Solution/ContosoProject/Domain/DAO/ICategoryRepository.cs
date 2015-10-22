using System.Collections.Generic;
using Domain.Entities.Products;

namespace Domain.DAO
{
    public interface ICategoryRepository : IRepositoryExtension<Category>
    {
        ICollection<Category> GetByTitle(string title);
    }
}
