﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;

namespace ContosoUI.ClientForm
{
    public class ClientModel
    {
        readonly IClientRepository _repository = new DummyDAOForClient();

        public void Save(Client currentClient)
        {
            _repository.Save(currentClient);
        }

        public void Create(Client newClient)
        {
            _repository.Create(newClient);
        }

        public Client Find(int id)
        {
            return _repository.Find(id);
        }

        public Client FindBy(string firstName, string lastName, string city)
        {
            var clientList = _repository.FindBy(firstName, lastName, city);
            return clientList == null ?  null :  clientList.FirstOrDefault();
        }
    }
}