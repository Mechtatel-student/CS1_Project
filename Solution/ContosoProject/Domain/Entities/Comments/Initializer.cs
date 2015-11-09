using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Comments
{
    public static class Comments
    {
        public static IList<Comment> Init(Users.User author, string entity ,bool isActive = true)
        {
            return new List<Comment> { new Comment { Author = author, IsActive = isActive, Text = string.Format("{0} was succesfully created", entity) } };
        }
    }
}
