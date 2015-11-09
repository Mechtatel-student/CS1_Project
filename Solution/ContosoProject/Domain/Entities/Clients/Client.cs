using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Clients
{
    public class Client : ExtendedEntity, ICommentable
    {       
        public Client(ICollection<Telephone> telephones, ICollection<Comment> comments)
        {
            Telephones = telephones;
            Comments = comments;
        }

        public Client()
        {
            
        }

        public Location ClientLocation { get; set; }
        public Person Person { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Telephone> Telephones { get; set; }

        protected bool Equals(Client other)
        {
            return ClientLocation.Equals(other.ClientLocation) && Person.Equals(other.Person) && Comments.SequenceEqual(other.Comments) && Telephones.Equals(other.Telephones);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Client) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (ClientLocation != null ? ClientLocation.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Person != null ? Person.GetHashCode() : 0);
                //hashCode = (hashCode*397) ^ (Comments != null ? Comments.GetHashCode() : 0);
                //hashCode = (hashCode*397) ^ (Telephones != null ? Telephones.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}