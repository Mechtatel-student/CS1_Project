using System.Linq;
using Domain.Entities.Products;

namespace Domain.Entities.Orders
{
    public static class OrderExtentions
    {
        public static void AddOrder(this Order Order, Product product, int quantity)
        {
            if (!Order.Contains(product))
                Order.OrderItems.Add(new OrderItem(product, quantity, product.Price));
            else
                Order.EditOrder(product, quantity);
        }

        public static bool Contains(this Order Order, Product product)
        {
            return Order.OrderItems.Any(x => x.Product == product);
        }

        public static void RemoveOrder(this Order Order, Product product)
        {
            Order.OrderItems.RemoveAll(x => x.Product == product);
        }

        public static void EditOrder(this Order Order, Product product, int quantity)
        {
            double price = product.Price;
            price = Order.OrderItems.Where(x => x.Product == product).Select(x => x.Price).First();

            Order.RemoveOrder(product);
            Order.OrderItems.Add(new OrderItem(product, quantity, price));
        }

    }
}
