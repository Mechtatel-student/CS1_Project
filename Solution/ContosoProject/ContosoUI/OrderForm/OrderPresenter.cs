using Domain.DAO;
using Domain.Entities.Clients;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ContosoUI.OrderForm
{
    public class OrderPresenter : Presenter, IViewPresenter
    {
        #region Fields
        private OrderModel _model;
        private IOrderView _view;

        private IProductRepository _produtRepository;
        private IClientRepository _clientRepository;

        private Order _order = new Order(Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Order"), new List<OrderItem>());
        private Client _client = new Client() { ClientLocation = new Location(), Person = new Domain.Entities.Person() };

        private string _orderNumber = string.Empty;
        private Status _status = Status.Opened;
        private DateTime _date = DateTime.Now;
        private double _totalPrice;
        private int _id;

        private bool _state;

        private BindingList<Comment> _comments = new BindingList<Comment>();
        private BindingList<OrderItem> _orderItems = new BindingList<OrderItem>();

        public BindingList<Client> ClientsList; 
        #endregion

        #region Constructors

        public OrderPresenter(OrderModel model, IOrderView view)
        {
            _model = model;
            _view = view;
            _produtRepository = _model.ProductRepository;
            _clientRepository = _model.ClientRepository;
            ClientsList = new BindingList<Client>(_clientRepository.GetAll().Where(x => x.IsActive == true).ToList());
        } 
        #endregion

        #region Methods
        public void OrderItemsComparer()
        {
            foreach (var item in OrderItems)
            {
                if (OrderItems.Where(x => x.Product == item.Product).Count() > 1)
                {
                    MessageBox.Show("Dublicate product in order items list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NotifyPropertyChanged();
                }
            }
        }

        public void Save()
        {
            if (_order.Id != 0)
            {
                _order.Comments = _comments;
                _order.Client = _client;
                _order.Date = _date;
                _order.OrderItems = _orderItems.ToList();
                _order.IsActive = _state;
                _order.Id = _id;
                _order.Status = _status;
                _order.OrderNumber = _orderNumber;

                _model.Save(_order);
            }
            else
            {
                var newOrderToSave = new Order(_comments, new List<OrderItem>(_orderItems))
                {
                    Client = _client,
                    Date = _date,
                    IsActive = _state,
                    Id = _id,
                    Status = _status,
                    OrderNumber = _orderNumber
                };

                _model.Create(newOrderToSave);
                _id = newOrderToSave.Id;
                _order = newOrderToSave;                
            }
        }

        public void New()
        {
            _order = new Order(Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Order"), new List<OrderItem>());
            _client = new Client() { ClientLocation = new Location(), Person = new Domain.Entities.Person() };
            _orderNumber = string.Empty;
            _status = Status.Opened;
            _date = DateTime.Now;
            _state = true;
            _orderItems = new BindingList<OrderItem>();
            _comments = new BindingList<Comment>();
            _id = 0;
            NotifyPropertyChanged();
        }

        public void SaveAndNew()
        {
            Save();
            New();
        }

        public bool State
        {
            get { return _state; }
            set
            {
                if (!Equals(value, _state))
                {
                    _state = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void UseOrderWithID(int id)
        {
            _order = _model.GetByID(id);

            _client = _order.Client;
            _orderNumber = _order.OrderNumber;
            _status = _order.Status;
            _date = _order.Date;
            _comments = new BindingList<Comment>(_order.Comments.ToList());
            _orderItems = new BindingList<OrderItem>(_order.OrderItems);
            _state = _order.IsActive;
            _id = id;
            _totalPrice = _order.Sum;
        }

        public override void Stop()
        {
            _model.Dispose();
        }
        #endregion

        #region Properties
        public string OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                if (value == _orderNumber) return;
                _orderNumber = value;
                NotifyPropertyChanged();
            }
        }

        public Status Status
        {
            get { return _status; }
            set
            {
                if (value == _status) return;
                _status = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value.Equals(_date)) return;
                _date = value;
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

        public BindingList<OrderItem> OrderItems
        {
            get { return _orderItems; }
            set
            {
                if (Equals(value, _orderItems)) return;
                _orderItems = value;
                NotifyPropertyChanged();
            }
        }

        public double TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                if (Equals(value, _totalPrice)) return;
                _totalPrice = value;
                NotifyPropertyChanged();
            }
        }



        public int ClientID
        {
            get { return (_client == null) ? 0 : _client.Id; }
            set
            {
                _client = ClientsList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged();
            }
        }

        public BindingList<Product> Products
        {
            get { return new BindingList<Product>(_produtRepository.GetAll().ToList()); }
        }

        public List<Status> StatusEnum
        {
            get
            {
                return Enum.GetValues(typeof(Status)).Cast<Status>().Skip(1).ToList();
            }
        } 
        #endregion
    }
}
