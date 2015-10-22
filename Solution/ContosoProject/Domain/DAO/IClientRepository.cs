using System.Collections.Generic;
using Domain.Entities;

namespace Domain.DAO
{
    public interface IClientRepository : IRepositoryExtension<Client>
    {
        ICollection<Client> FindBy(Person person, string city);
    }
}