using Data.Design;
using Domain.DAO;
using Domain.Entities.Orders;

namespace ContosoUI.OrderForm
{
    public class OrderModel: Model
    {
        public OrderModel()
            :base()
        {

        }

        public IOrderRepository OrderRepository
        {
            get { return Facade.OrderRepository; }
        }
        public IProductRepository ProductRepository
        {
            get { return Facade.ProductRepository; }
        }
        public IClientRepository ClientRepository
        {
            get { return Facade.ClientRepository; }
        }

        public void Save(Order currentOrder)
        {
            OrderRepository.Update(currentOrder);
        }
        public void Create(Order currentOrder)
        {
            OrderRepository.Create(currentOrder);
        }

        public Order GetByNumber(string orderNumber)
        {
            return OrderRepository.GetByNumber(orderNumber);
        }

        public Order GetByID(int id)
        {
            return OrderRepository.Read(id);
        }
         
    }
}
