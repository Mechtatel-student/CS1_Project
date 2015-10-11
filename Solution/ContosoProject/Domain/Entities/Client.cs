using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Client : Person,  ICommentable
    {
        List<Comment> comments=new List<Comment>();
        
        public Location Location { get; set; }
        public IReadOnlyList<string> telephones { get; set; }

        public IReadOnlyList<Comment> Comments
        {
            get { return comments1; }
        }
        public void  AddComment(Comment comment)
        {
            comments1.Add(comment);
        }
 
    }
}
