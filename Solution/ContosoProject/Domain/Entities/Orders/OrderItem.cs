using Domain.Entities.Products;

namespace Domain.Entities.Orders
{
    public class OrderItem : Entity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }        
    }
}
