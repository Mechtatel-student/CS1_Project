using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    class Client : Person, ICommentable
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
        public Client(string firstName1, string middleName1, string lastName1, Location location,
                    List<string> telephones1): base(firstName1,middleName1,lastName1)
        {
            Location = location;
            telephones = telephones1;
        }
    }
}
