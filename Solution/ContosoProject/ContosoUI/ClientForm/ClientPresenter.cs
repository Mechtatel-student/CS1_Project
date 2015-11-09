using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ContosoUI.ClientForm
{
    public class ClientPresenter : Presenter, IViewPresenter
    {
        private IClientView _view;
        private ClientModel _model;

        private readonly IClientRepository _clientRepository;
        private readonly IOrderRepository _orderRepository;

        private Client _client = new Client(
            new List<Telephone>(), 
            Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Client"));

        private string _firstName = string.Empty;
        private string _middleName = string.Empty;
        private string _lastName = string.Empty;

        private string _city = string.Empty;
        private string _address = string.Empty;
        private BindingList<Telephone> _telephones = new BindingList<Telephone>();

        private BindingList<Order> _orders = new BindingList<Order>();
        private BindingList<Comment> _comments = new BindingList<Comment>();
        public bool State { get; set; }
        private int _id;

        public ClientPresenter(IClientView view, ClientModel model)
        {
            _view = view;
            _model = model;
            _clientRepository = _model.ClientRepository;
            _orderRepository = _model.OrderRepository;
        }

        public void UseClientWithID(int id)
        {
            _client = _clientRepository.Read(id);
            InitializeClientsFields();
            _id = id;           
        }

        private void InitializeClientsFields()
        {
            _firstName = _client.Person.FirstName;
            _middleName = _client.Person.MiddleName;
            _lastName = _client.Person.LastName;
            _city = _client.ClientLocation.City;
            _address = _client.ClientLocation.Address;
            _telephones = new BindingList<Telephone>(_client.Telephones.ToList());
            State = _client.IsActive;
            _orders = new BindingList<Order>(_orderRepository.GetByClient(_client).ToList());
            _comments = new BindingList<Comment>(_client.Comments.ToList());
        }

        #region Properties

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                NotifyPropertyChanged();
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == _middleName) return;
                _middleName = value;
                NotifyPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (value == _city) return;
                _city = value;
                NotifyPropertyChanged();
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value == _address) return;
                _address = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Telephone> Telephones
        {
            get { return _telephones; }
            set
            {
                if (Equals(value, _telephones)) return;
                _telephones = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Order> Orders
        {
            get { return _orders; }
            set
            {
                if (Equals(value, _orders)) return;
                _orders = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> Comments
        {
            get { return _comments; }
            set
            {
                if (Equals(value, _comments)) return;
                _comments = value;
                NotifyPropertyChanged();
            }
        }

        #endregion



        public void Save()
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleName) || string.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("Fill the fields, please.", "Attention!");
                return;
            }
            if (_client.Id != 0)
            {
                _client.Telephones = _telephones;
                _client.Comments = _comments;
                _client.Person.FirstName = _firstName;
                _client.Person.MiddleName = _middleName;
                _client.Person.LastName = _lastName;
                _client.ClientLocation.Address = _address;
                _client.ClientLocation.City = _city;
                _client.IsActive = State;

                _model.Save(_client);
            }
            else
            {
                Client clientToSave = new Client(_telephones, _comments)
                {
                    Person = new Person() {FirstName = _firstName, MiddleName = _middleName, LastName = _lastName},
                    ClientLocation = new Location() {Address = _address, City = _city},
                    IsActive = State,
                    Id = _id
                };
                if (_model.FindBy(clientToSave.Person.FirstName, clientToSave.Person.LastName, clientToSave.ClientLocation.City) == null)
                {
                    _model.Create(clientToSave);
                    _client = clientToSave;
                }
                else
                {
                    MessageBox.Show("Client already exists, use another one, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }


        public void New()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;

            City = string.Empty;
            Address = string.Empty;

            Telephones = new BindingList<Telephone>();
            Orders = new BindingList<Order>();
            Comments = new BindingList<Comment>();

            State = true;
            _client = new Client(
            new List<Telephone>(),
            Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Client"));
        }

        public void SaveAndNew()
        {
            Save();
            New();
        }

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
