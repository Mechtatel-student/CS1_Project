using System;
using System.Collections.Generic;
using Domain.Entities.Comments;
using Domain.Entities.Orders;

namespace Data.StoreData
{
    public static partial class Storage
    {
        public static List<List<OrderItem>> OrderItems = new List<List<OrderItem>>
        {
            new List<OrderItem>{new OrderItem(Products[0], 2, 120), new OrderItem(Products[1], 2, 200), new OrderItem(Products[3], 3, 60), new OrderItem(Products[4], 2, 100)},
            new List<OrderItem>{new OrderItem(Products[0], 2, 230), new OrderItem(Products[3], 1, 400)},
            new List<OrderItem>{new OrderItem(Products[4], 1, 80)},
            new List<OrderItem>{}
        }; 

        public static List<Order> Orders = new List<Order>
         {
             new Order(new List<Comment>(), OrderItems[0]){Client = Clients[0], User = Users[3], Id = 1, IsActive = true, Status = Status.Opened, Date = DateTime.Today},
             new Order(new List<Comment>(), OrderItems[1]){Client = Clients[2], User = Users[4], Id = 2, IsActive = true, Status = Status.Closed, Date = DateTime.Today.AddDays(-5)},
             new Order(new List<Comment>(), OrderItems[2]){Client = Clients[1], User = Users[3], Id = 3, IsActive = true, Status = Status.Opened, Date = DateTime.Today.AddDays(-3)},
             new Order(new List<Comment>(), OrderItems[3]){Client = Clients[2], User = Users[5], Id = 4, IsActive = true, Status = Status.PaidUp, Date = DateTime.Today.AddDays(-40)}
         };
    }
}
