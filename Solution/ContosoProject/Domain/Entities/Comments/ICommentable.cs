using System.Collections.Generic;

namespace Domain.Entities.Comments
{
    public interface ICommentable
    {
        ICollection<Comment> Comments { get; set; }
    }
}
