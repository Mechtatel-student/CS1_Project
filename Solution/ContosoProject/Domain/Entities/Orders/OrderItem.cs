using Domain.Entities.Products;

namespace Domain.Entities.Orders
{
    public class OrderItem : Entity
    {
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public OrderItem()
        {

        }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} pcs, {2} UAH", Product, Quantity, Price);
        }
    }
}
