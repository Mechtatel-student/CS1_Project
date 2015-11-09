using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;

namespace Data.Design
{
    public class DummyFacade: IRepositoryFacade
    {
        private IClientRepository _clientRepository;
        private IOrderRepository _orderRepository;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IPermissionRepository _permissionRepository;
        private ICommentRepository _commentRepository;

        public IClientRepository ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new DummyData.DummyDAOForClient();
                return _clientRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new DummyData.DummyDAOForOrder();
                return _orderRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new DummyData.DummyDAOForProduct();
                return _productRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new DummyData.DummyDAOForCategory();
                return _categoryRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new DummyData.DummyDAOForUser();
                return _userRepository;
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new DummyData.DummyDAOForRole();
                return _roleRepository;
            }
        }

        public IPermissionRepository PermissionRepository
        {
            get
            {
                if (_permissionRepository == null)
                    _permissionRepository = new DummyData.DummyDAOForPermission();
                return _permissionRepository;
            }
        }

        public ICommentRepository CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new DummyData.DummyDAOForComment();
                return _commentRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
