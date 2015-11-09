using Data.Design;
using Domain.DAO;
using Domain.Entities.Clients;
using Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ContosoUI.OrderSearchForm
{
    public class OrderListPresenter : Presenter, ISearchPresenter
    {
        private readonly IOrderListView _view;
        private readonly OrderListModel _model;

        private readonly IOrderRepository _orderRepository;
        private readonly IClientRepository _clientRepository;

        private BindingList<Order> ordersList = new BindingList<Order>();
        public BindingList<Client> ClientsList;
        public BindingList<Status> StatusList = new BindingList<Status>(Enum.GetValues(typeof(Status)).Cast<Status>().ToList());               

        public OrderListPresenter(IOrderListView view, OrderListModel model)
        {            
            _view = view;
            _model = model;
            _orderRepository = _model.OrderRepository;
            _clientRepository = _model.ClientRepository;
            ClientsList = new BindingList<Client>(_clientRepository.GetAll().ToList());
        }

        private string orderNumber = string.Empty;
        public string OrderNumber
        {
            get { return orderNumber; }
            set
            {
                this.orderNumber = value;
                NotifyPropertyChanged();
            }
        }

        Client Client;
        public int ClientID
        {
            get { return (Client == null) ? 0 : Client.Id; }
            set
            {
                Client = ClientsList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged();
            }
        }

        public Status status;
        public Status StatusEnum
        {
            get
            { return status; }
            set
            {
                this.status = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Order> OrdersList
        {
            get { return ordersList; }
            set
            {
                if (value != this.ordersList)
                {
                    this.ordersList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void Edit(int id)
        {
            OrderForm.OrderForm editOrderForm = new OrderForm.OrderForm(id);
            editOrderForm.MdiParent = Program.MainForm;
            editOrderForm.Show();
        }

        public void Search()
        {
            List<Order> orders;

            if (string.IsNullOrEmpty(OrderNumber) && Client == null && StatusEnum == Status.All)
                orders = _orderRepository.GetAll().ToList();
            else
                orders = _orderRepository.GetBy(OrderNumber, StatusEnum, Client).ToList(); 

            OrdersList = new BindingList<Order>(orders);
        }

        public void Clear()
        {
            OrderNumber = null;
            Client = null;            
            StatusEnum = Status.All;
            OrdersList.Clear();
        }

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
