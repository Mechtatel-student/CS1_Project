using System;
using System.Collections.Generic;

namespace Domain.DAO
{
    public interface IRepositoryExtension<T> : IRepository<T>
    {
        ICollection<T> GetByDate(DateTime date);
    }
}