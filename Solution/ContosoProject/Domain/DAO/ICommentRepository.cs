using System.Collections.Generic;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface ICommentRepository : IRepositoryExtension<Comment>
    {
        ICollection<Comment> GetByUser(User user);
    }
}
