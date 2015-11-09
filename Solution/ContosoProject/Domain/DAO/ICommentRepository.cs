using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface ICommentRepository : IRepositoryExtension<Comment>
    {
        ICollection<Comment> GetAllByUser(User user);
    }
}
