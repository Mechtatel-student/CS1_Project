using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Domain.Entities.Products
{
    /// <summary>
    /// The entity that describes the type of product
    /// </summary>
    public class Category: ExtendedEntity, ICommentable
    {
        public virtual ICollection<Comment> Comments { get; set; }
        public string Title { get; set; }

        public Category(ICollection<Comment> comments) : this()
        {
            Comments = comments;
        }

        public Category()
        {
        }

        public static bool IsNullOrEmpty(Category category)
        {
            return category == null || category.Title == "";
        }

        public override string ToString()
        {
            return string.Format("{0}", Title);
        }
    }
}
