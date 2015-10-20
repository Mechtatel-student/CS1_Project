using System.Collections.Generic;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;

namespace Data.DummyData
{
    class DummyDAOForComment : DummyDAOExtension<Comment>, ICommentRepository
    {
        public DummyDAOForComment()
        {
            _collection = Storage.GodComments;
        }
    }
}
