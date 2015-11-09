using System;
using System.Collections.Generic;

namespace Domain.Entities.Users
{
    public class Role : Entity, ICloneable
    {
        public Role(ICollection<Permission> permissions)
        {
            Permissions = permissions;
        }

        public Role()
        {
        }

        public string Title { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }

        public override string ToString()
        {
            return Title;
        }

        protected bool Equals(Role other)
        {
            return string.Equals(Title, other.Title) && Equals(Permissions, other.Permissions) && Id.Equals(other.Id);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Role) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Title != null ? Title.GetHashCode() : 0)*397) ^ (Permissions != null ? Permissions.GetHashCode() : 0) ^ (Id.GetHashCode() * 632);
            }
        }

        public object Clone()
        {
            return new Role(Permissions) {Id = Id, IsActive = IsActive, Title=Title};
        }
    }
}
