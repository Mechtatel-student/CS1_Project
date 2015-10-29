﻿using Domain.Entities;
using Domain.Entities.Clients;
using System.Collections.Generic;

namespace Domain.DAO
{
    public interface IClientRepository : IRepositoryExtension<Client>
    {
        ICollection<Client> GetBy(Person person, string city);
    }
}