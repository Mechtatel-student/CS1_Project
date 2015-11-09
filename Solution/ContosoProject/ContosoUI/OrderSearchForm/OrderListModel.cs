using Domain.DAO;

namespace ContosoUI.OrderSearchForm
{
    public class OrderListModel: Model
    {
        public OrderListModel()
            :base()
        {

        }
        public IClientRepository ClientRepository 
        {
            get { return Facade.ClientRepository; }
        }

        public IOrderRepository OrderRepository
        {
            get { return Facade.OrderRepository; }
        }
    }
}
