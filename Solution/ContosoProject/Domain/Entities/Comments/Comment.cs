using Domain.Entities.Users;

namespace Domain.Entities.Comments
{
    public enum EntityType
    {
        User,
        Client,
        Product,
        Order,
        Category
    }
    public class Comment: ExtendedEntity
    {
        public Comment()
        {
        }

        public User Author { get; set; }
        public string Text { get; set; }

        public EntityType EntityType { get; set; }
        public override string ToString()
        {
            return Author != null ? string.Format("\"{0}\", {1}", Text, Date.ToShortDateString()) : string.Format("\"{0}\", {1} {2}", Text, Date.ToShortDateString(), Author);
        }
        #region Equals
        protected bool Equals(Comment other)
        {
            return Equals(Author, other.Author) && string.Equals(Text, other.Text) && EntityType == other.EntityType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Comment) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Author != null ? Author.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Text != null ? Text.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (int) EntityType;
                return hashCode;
            }
        }
        #endregion
    }

}
