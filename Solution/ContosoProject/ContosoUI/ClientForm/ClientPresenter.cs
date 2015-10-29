﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;

namespace ContosoUI.ClientForm
{
    public class ClientPresenter : Presenter, IViewPresenter
    {
        private IClientView _view;
        private ClientModel _model;

        readonly IClientRepository _clientRepository = new DummyDAOForClient();
        readonly IOrderRepository _orderRepository = new DummyDAOForOrder();

        Client _client = new Client();

        private string _firstName = string.Empty;
        private string _middleName = string.Empty;
        private string _lastName = string.Empty;

        private string _city = string.Empty;
        private string _address = string.Empty;
        private List<string> _telephones = new List<string>(); 

        BindingList<Order> _orders = new BindingList<Order>();
        BindingList<Comment> _comments = new BindingList<Comment>();  

        public ClientPresenter(IClientView view, ClientModel model)
        {
            _view = view;
            _model = model;
        }

        public void UseClientWithID(int id)
        {
            _client = _clientRepository.Find(id);
            InitializeClientsFields();
        }

        //public ClientPresenter(IClientView view, ClientModel model, Client client)
        //{
        //    _view = view;
        //    _model = model;
        //    _client = client;
        //    InitializeClientsFields();
        //}

        private void InitializeClientsFields()
        {
            _firstName = _client.Person.FirstName;
            _middleName = _client.Person.MiddleName;
            _lastName = _client.Person.LastName;
            _city = _client.ClientLocation.City;
            _address = _client.ClientLocation.Address;
            _telephones = _client.Telephones.ToList();
            _orders = new BindingList<Order>(_orderRepository.GetByClient(_client).ToList());
            _comments = new BindingList<Comment>(_client.Comments.ToList());
        }

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

        public List<string> Telephones
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

        public void Save()
        {
            Client clientToSave = new Client(_telephones, _comments) {Person = new Person() { FirstName = _firstName, MiddleName = _middleName, LastName = _lastName}, 
                ClientLocation = new Location() { Address = _address, City = _city}, Date = _client.Date, IsActive = _client.IsActive, Id = _client.Id};
            try
            {
                var clientToCompare = _model.Find(_client.Id);
                if (!clientToSave.Equals(clientToCompare))
                {
                    _model.Save(clientToSave);
                    _client = clientToSave;
                    InitializeClientsFields();
                } 
            }
            catch
            {
                _model.Create(clientToSave);
            }
            
        }

        public void Clear()
        {
            _firstName = string.Empty;
            _middleName = string.Empty;
            _lastName = string.Empty;

            _city = string.Empty;
            _address = string.Empty;

            _telephones = new List<string>();
            _orders = new BindingList<Order>();
            _comments = new BindingList<Comment>();

            _client = new Client(_telephones, _comments);
        }

        public void SaveAndNew()
        {
            Save();
            Clear();
        }

        public void ShowView(ClientPresenter presenter, int id)
        {
            _view.ShowView(presenter, id);
        }
    }
}