using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Client : Person,  ICommentable
    {
        List<Comment> comments1;
        
        public Location Location { get; set; }
        public IReadOnlyList<string> telephones;

        public IReadOnlyList<Comment> comments
        {
            get { return comments1; }
        }
        public void  AddComment(Comment comment)
        {
            comments1.Add(comment);
        }
        public Client(IReadOnlyList<string> telephones1)
        {

            telephones = telephones1;
        }
    }
}
