using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Clients;

namespace Data.DummyData
{
    public class DummyDAOForOrder : DummyDAOExtension<Order>, IOrderRepository
    {
        public DummyDAOForOrder()
        {
            Collection = Storage.Orders;
        }

        public ICollection<Order> GetBy(string orderNumber, Status status, Client client)
        {
            var result = Collection.AsQueryable();

            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                return result.Where(x => x.OrderNumber == orderNumber).ToList();
            }

            if (client != null)
            {
                result = result.Where(x => x.Client.Equals(client));
            }

            if (status != Status.All)
            {
                result = result.Where(x => x.Status == status);
            }

            if (!Equals(result, Collection.AsQueryable()))
            {
                return result.ToList();
            }
            throw new Exception();
        }

        public Order GetByNumber(string orderNumber)
        {
            if (string.IsNullOrWhiteSpace(orderNumber))
                return Collection.FirstOrDefault(x => x.OrderNumber == orderNumber);
            return null;
        }

        public ICollection<Order> GetByStatus(Status status)
        {
            return Collection.Where(x => x.Status == status).ToList();
        }

        public ICollection<Order> GetByClient(Client client)
        {
            if (Collection.Any(x => x.Client == client))
            {
                return Collection.Where(x => x.Client == client).ToList();
            }
            return new List<Order>();
        }

        public ICollection<Order> GetByProduct(Product product)
        {
            if (Contains(product))
            {
                return Collection.Where(x => x.OrderItems.Any(it => it.Product == product)).ToList();
            }
            return new List<Order>();
        }
        //TODO fix
        public void AddOrder(Order order, Product product, int quantity)
        {
            if (!Contains(product))
            {
                Collection.Add(new Order(new List<Comment>(), new List<OrderItem>
                {
                    new OrderItem(product, quantity, product.Price)
                }));
            }
            throw new Exception();
        }

        private bool Contains(Product product)
        {
            return Collection.Any(x => x.OrderItems.Any(it => it.Product == product));
        }
        //TODO fix
        public void RemoveOrder(Order order, Product product)
        {
            if (Contains(product))
            {
                Collection.First(x => x.OrderItems.Any(it => it.Product == product)).IsActive = false;
            }
            throw new Exception();
        }
        //TODO fix
        public void EditOrder(Order order, Product product, int quantity)
        {
            if (Contains(product))
            {
                var prod = Collection[Collection.IndexOf(Collection.First(x => x.OrderItems.Any(it => it.Product == product)))].OrderItems.First(x => x.Product == product);
                prod.Quantity = quantity;
            }
            throw new Exception();
        }
        [Obsolete("This method was used in case of sum of ALL the orders of target, now use GetAll and Sum for it")]
        public double Sum
        {
            get { return Collection.Sum(x => x.Sum); }
        }
    }
}