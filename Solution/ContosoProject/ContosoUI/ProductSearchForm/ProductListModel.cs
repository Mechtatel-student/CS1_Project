using Domain.DAO;

namespace ContosoUI.ProductSearchForm
{
    public class ProductListModel:Model
    {
        public ProductListModel()
            :base()
        {

        }
        public IProductRepository ProductRepository
        {
            get { return Facade.ProductRepository; }
        }

        public ICategoryRepository CategoryRepository 
        {
            get { return Facade.CategoryRepository; } 
        }
    }
}
