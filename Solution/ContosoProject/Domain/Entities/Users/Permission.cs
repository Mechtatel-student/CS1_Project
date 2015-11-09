using System.Collections.Generic;
namespace Domain.Entities.Users
{
    public class Permission : Entity
    {
        public Permission()
        {
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Description != string.Empty ? string.Format("{0}: {1}", Title, Description) : Title;
        }
        public virtual ICollection<Role> Roles { get; set; }

        protected bool Equals(Permission other)
        {
            return Title.Equals(other.Title); // && Description.Equals(other.Description) && Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Permission) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Title != null ? Title.GetHashCode() : 0)*397) ^ (Description != null ? Description.GetHashCode() : 0);
            }
        }
    }
}
