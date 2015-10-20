using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities
{
    public class Client : ExtendedEntity, ICommentable
    {
        public Location ClientLocation { get; set; }
        public Person Person { get; set; }
        private ICollection<string> _telephones;
        private ICollection<Comment> _comments;
        public Client(ICollection<string> telephones, ICollection<Comment> comments)
        {
            _telephones = telephones;
            _comments = comments;
        }

        public Client()
        {
            
        }

        public IReadOnlyCollection<string> Telephones
        {
            get
            {
                return (IReadOnlyCollection<string>)_telephones;
            }
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }
    }
}