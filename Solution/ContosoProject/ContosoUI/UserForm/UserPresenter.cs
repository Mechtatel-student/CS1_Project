using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Users;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ContosoUI.UserForm
{
    internal class UserPresenter : Presenter, IViewPresenter
    {
        private readonly IUserView _view;
        private readonly UserModel _model;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;

        public UserPresenter(IUserView view, UserModel model)
        {
            _view = view;
            _model = model;
            _roleRepository = _model.RoleRepository;
            _userRepository = _model.UserRepository;
            var roles = _roleRepository.GetAll();
            RoleList = new List<Role>(roles);            
        }

        User _user = new User
        {
            Person = new Person(),
            Role = new Role
            {
                Permissions = new List<Permission>()
            }            
        };
        private string _password = string.Empty;
        public List<Role> RoleList;

        BindingList<Permission> _permissions = new BindingList<Permission>();

        #region Properties
        public string Login
        {
            get { return _user.Login; }
            set
            {
                if (value != _user.Login)
                {
                    _user.Login = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get { return _user.Person.FirstName; }
            set
            {
                if (value != _user.Person.FirstName)
                {
                    _user.Person.FirstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string MiddleName
        {
            get { return _user.Person.MiddleName; }
            set
            {
                if (value != _user.Person.MiddleName)
                {
                    _user.Person.MiddleName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get { return _user.Person.LastName; }
            set
            {
                if (value != _user.Person.LastName)
                {
                    _user.Person.LastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    _user.Password = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BindingList<Permission> Permissions
        {
            get { return new BindingList<Permission>(_user.Role.Permissions.ToList()); }
            set
            {
                if (!value.SequenceEqual(Permissions))
                {
                    _user.Role.Permissions = value;
                    NotifyPropertyChanged();
                }
                
            }
        }

         public int RoleID
        {
            get { return (_user.Role == null) ? 0 : _user.Role.Id; }
            set
            {
                _user.Role = RoleList.FirstOrDefault(x => x.Id == value);
                if (_user.Role != null) Permissions = new BindingList<Permission>(_user.Role.Permissions.ToList());
                NotifyPropertyChanged();
            }
        }
        public bool State
        {
            get { return _user.IsActive; }
            set
            {
                if (value != _user.IsActive)
                {
                    _user.IsActive = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        public void GetUser(int id)
        {
            _user  = _userRepository.Read(id);

            Login = _user.Login;
            Password = _user.Password;
            FirstName = _user.Person.FirstName;
            MiddleName = _user.Person.MiddleName;
            LastName = _user.Person.LastName;
            RoleID = _user.Role.Id;
            
            Permissions = new BindingList<Permission>(_user.Role.Permissions.ToList());
            State = _user.IsActive;
        }

        public void Save()
        {
            if (_user.Id != 0)
            {
                _model.Save(_user);
            }
            else
            {
                _model.Create(_user);
            }
        }

        public void SaveAndNew()
        {
            Save();
            New();
        }

        public void New()
        {
            _user = new User
            {
                Person = new Person(),
                Role = new Role()
                {
                    Permissions = new BindingList<Permission>()
                }
            };
            Login = "";
            Password = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            State = true;
        }

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
