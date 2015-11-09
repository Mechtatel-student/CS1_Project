using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Products
{
    public class Product : ExtendedEntity, ICommentable
    {
        public Product(ICollection<Comment> comments)
        {
            Comments = comments;
        }

        public Product()
        {
        }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string SKU { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        //public static bool operator ==(Product product1, Product product2)
        //{
        //    return product1.Equals(product2);
        //}

        //public static bool operator !=(Product product1, Product product2)
        //{
        //    return !product1.Equals(product2);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != this.GetType()) return false;
        //    return Equals((Product) obj);
        //}

        public override string ToString()
        {
            return Title;
        }
        //protected bool Equals(Product other)
        //{
        //    return Comments.SequenceEqual(other.Comments) && Quantity == other.Quantity && Price.Equals(other.Price) && string.Equals(Title, other.Title) && Equals(Category, other.Category);
        //}

        //public override int GetHashCode()
        //{
        //    unchecked
        //    {
        //        var hashCode = (Comments != null ? Comments.GetHashCode() : 0);
        //        hashCode = (hashCode * 397) ^ Quantity;
        //        hashCode = (hashCode * 397) ^ Price.GetHashCode();
        //        hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
        //        hashCode = (hashCode * 397) ^ (Category != null ? Category.GetHashCode() : 0);
        //        return hashCode;
        //    }
        //}

    }
}
