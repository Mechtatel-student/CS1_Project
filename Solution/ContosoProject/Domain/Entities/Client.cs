using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities
{
    public class Client : ExtendedEntity, ICommentable
    {
        private readonly List<Comment> _comments = new List<Comment>()
        {
            new Comment
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Client,
                Text = string.Format("Client has been added ")
            }
        };

        private readonly List<string> _telephones = new List<string>();

        public Client(ICollection<string> telephones, ICollection<Comment> comments)
        {
            _telephones = telephones.ToList();
            _comments = comments.ToList();
        }

        public Client() : base()
        {
        }

        public Location ClientLocation { get; set; }
        public Person Person { get; set; }

        public IReadOnlyCollection<string> Telephones
        {
            get { return _telephones; }
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return _comments; }
        }

        public override string ToString()
        {
            return Person.ToString();
        }

        protected bool Equals(Client other)
        {
            return _telephones.SequenceEqual(other._telephones) && _comments.SequenceEqual(other._comments) && ClientLocation.Equals(other.ClientLocation) && Person.Equals(other.Person);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_telephones != null ? _telephones.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (_comments != null ? _comments.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (ClientLocation != null ? ClientLocation.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Person != null ? Person.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Client)) return false;
            return Equals((Client) obj);
        }
    }
}