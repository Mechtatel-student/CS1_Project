using Data.Design;
using Domain.DAO;
using Domain.Entities.Products;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ContosoUI.ProductSearchForm
{
    public class ProductListPresenter : Presenter, ISearchPresenter
    {
        private readonly IProductListView _view;
        private readonly ProductListModel _model;

        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public List<Category> CategoriesList;

        public ProductListPresenter(IProductListView view, ProductListModel model)
        {            
            _view = view;
            _model = model;
            _productRepository = _model.ProductRepository;
            _categoryRepository = _model.CategoryRepository;
            CategoriesList = new List<Category>(_categoryRepository.GetAll().ToList());
        }

        private string sku = string.Empty;
        public string SKU
        {
            get { return sku; }
            set
            {
                if (value != this.sku)
                {
                    this.sku = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string title = string.Empty;
        public string Title
        {
            get { return title; }
            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Category Category;
        public int CategoryID
        {
            get { return (Category == null) ? 0 : Category.Id; }
            set
            {
                Category = CategoriesList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged();
            }
        }

        private BindingList<Product> productList = new BindingList<Product>();
        public BindingList<Product> Products
        {
            get { return productList; }
            set
            {
                if (value != this.productList)
                {
                    this.productList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void Edit(int id)
        {
            ProductForm.ProductView editProductForm = new ProductForm.ProductView(id);
            editProductForm.MdiParent = Program.MainForm;
            editProductForm.Show();
        }

        public void Search()
        {
            List<Product> products;
            if (SKU != null && Title != null && Category != null)
                products = _productRepository.GetBy(SKU, Title, Category).ToList();
            else
                products = _productRepository.GetAll().ToList();

            Products = new BindingList<Product>(products);
        }

        public void Clear()
        {
            SKU = null;
            Title = null;
            Category = null;
            Products.Clear();
            NotifyPropertyChanged();
        }

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
