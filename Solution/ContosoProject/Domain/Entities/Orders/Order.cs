using Domain.Entities.Clients;
using Domain.Entities.Comments;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Domain.Entities.Orders
{
    public enum Status { All, Opened, PaidUp, Finished, Shipped, Closed }

    public class Order : ExtendedEntity, ICommentable
    {
        public Order(ICollection<Comment> comments, ICollection<OrderItem> orders)
        {
            Comments = comments;
            OrderItems = orders.ToList();
        }

        public Order()
        {

        }

        public Client Client { get; set; }
        public Status Status { get; set; }
        public string OrderNumber { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }

        public double Sum
        {
            get { return OrderItems.Sum(x => x.Price * x.Quantity); }
        }
    }
}
