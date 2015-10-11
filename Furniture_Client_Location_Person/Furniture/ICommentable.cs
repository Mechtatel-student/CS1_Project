using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    interface ICommentable
    {
       IReadOnlyList<Comment> comments {get; }
    }
}
