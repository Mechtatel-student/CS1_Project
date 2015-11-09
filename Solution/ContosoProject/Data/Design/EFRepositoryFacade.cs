using Data.EFRepository;
using Domain.DAO;

namespace Data.Design
{
    public class EFRepositoryFacade: IRepositoryFacade
    {

        private readonly ProjectContext _context;

        private bool _disposed;

        private IClientRepository _clientRepository;
        private IOrderRepository _orderRepository;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IPermissionRepository _permissionRepository;
        private ICommentRepository _commentRepository;

        public EFRepositoryFacade(ProjectContext context = null)
        {
            _context = context ?? new ProjectContext();
        }

        public IClientRepository ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new EFRepository.EFClientDAO(_context);
                return _clientRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new EFRepository.EFOrderDAO(_context);
                return _orderRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new EFRepository.EFProductDAO(_context);
                return _productRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new EFRepository.EFCategoryDAO(_context);
                return _categoryRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new EFRepository.EFUserDAO(_context);
                return _userRepository;
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new EFRepository.EFRoleDAO(_context);
                return _roleRepository;
            }
        }

        public IPermissionRepository PermissionRepository
        {
            get
            {
                if (_permissionRepository == null)
                    _permissionRepository = new EFRepository.EFPermissionDAO(_context);
                return _permissionRepository;
            }
        }

        public ICommentRepository CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new EFRepository.EFCommentDAO(_context);
                return _commentRepository;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if(disposing)
            {
                _context.Dispose();
            }

            _clientRepository = null;
            _orderRepository = null;
            _productRepository = null;
            _categoryRepository = null;
            _userRepository = null;
            _roleRepository = null;
            _permissionRepository = null;
            _commentRepository = null;

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
