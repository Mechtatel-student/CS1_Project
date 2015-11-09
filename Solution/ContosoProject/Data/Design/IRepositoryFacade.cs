using Domain.DAO;
using System;
namespace Data.Design
{
    public interface IRepositoryFacade : IDisposable
    {
        IClientRepository ClientRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        ICommentRepository CommentRepository { get; }
    }
}
