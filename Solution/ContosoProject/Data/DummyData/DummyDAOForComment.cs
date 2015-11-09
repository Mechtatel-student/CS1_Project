using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAOForComment : DummyDAOExtension<Comment>, ICommentRepository
    {
        public ICollection<Comment> GetAllByUser(User user)
        {
            if (Collection.Any(x => x.Author == user))
            {
                return Collection.Where(x => x.Author == user).ToList();
            }
            throw new Exception();
        }

        public DummyDAOForComment()
        {
            Collection = Storage.GodComments;
        }
    }
}