using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities.Products
{
    /// <summary>
    /// The entity that describes the type of product
    /// </summary>
    public class Category: ExtendedEntity, ICommentable
    {
        private ICollection<Comment> _comments;

        public Category(ICollection<Comment> comments)
        {
            _comments = comments;
        }

        public Category()
        {
        }

        public static bool IsNullOrEmpty(Category category)
        {
            return category == null || category.Title == "";
        }

        public string Title { get; set; }

        public IReadOnlyCollection<Comment> Comments
        {
            get 
            {
                return (IReadOnlyCollection<Comment>)_comments;
            }
        }
    }
}
