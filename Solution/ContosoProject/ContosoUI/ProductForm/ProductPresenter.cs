using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ContosoUI.ProductForm
{
    public class ProductPresenter : Presenter, IViewPresenter
    {
        private readonly IProductView _view;
        private readonly ProductModel _model;

        private readonly ICategoryRepository _categoryRepository;

        private Product _product = new Product(Comments.Init(Program.AuthUser, "Product"));

        private bool _isActive;
        private string _sku = string.Empty;
        private string _title = string.Empty;
        private int _quantity;
        private double _price;
        private Category _category;
        BindingList<Comment> _productComments = new BindingList<Comment>(); 

        private String _searchTitleCategory = string.Empty;
        BindingList<Category> _categories = new BindingList<Category>();
        BindingList<Comment> _categoryComments = new BindingList<Comment>();
        private Category _categoryInUse = new Category(Comments.Init(Program.AuthUser, "Category"));
        private int _id;
        private bool _state;

        public ProductPresenter(IProductView view, ProductModel model)
        {
            _view = view;
            _model = model;
            _categoryRepository = _model.CategoryRepository;
            InitializeProductFields();
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        private void InitializeAllTheFields()
        {
            InitializeProductFields();
            InitializeCategoryFields();
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        private void InitializeProductFields()
        {
            _id = _product.Id;
            IsActive = _product.IsActive;
            SKU = _product.SKU;
            Title = _product.Title;
            Quantity = _product.Quantity;
            Price = _product.Price;
            Category = _product.Category;
            _productComments = new BindingList<Comment>(_product.Comments.ToList());
            _searchTitleCategory = string.Empty;
        }

        private void InitializeCategoryFields()
        {
            _categoryComments = new BindingList<Comment>( _categoryInUse.Comments.ToList());
        }

        public void UseProductWithID(int id)
        {
            _product = _model.Find(id);
            InitializeProductFields();
        }

        public void UseCategoryWithID(int id)
        {
            if(id != 0)
            {                
                _categoryInUse = _categoryRepository.Read(id);
                _category = _categoryInUse;
                NotifyPropertyChanged();
            }
            _categoryComments = new BindingList<Comment>(_categoryInUse.Comments.ToList());
        }

        public void Save()
        {
            SaveProduct();
        }

        private void SaveProduct()
        {
            if (_product.Id != 0)
            {
                _product.Comments = _productComments;
                _product.Category = _category;
                _product.Price = _price;
                _product.Quantity = _quantity;
                _product.SKU = _sku;
                _product.Title = _title;
                _product.Id = _id;
                _product.IsActive = _isActive;

                _model.Save(_product);
            }
            else
            {
                var newProductToSave = new Product(_productComments)
                {
                    Category = _category,
                    Price = _price,
                    Quantity = _quantity,
                    SKU = _sku,
                    Title = _title,
                    Id = ID,
                    IsActive = _isActive
                };
                _model.Create(newProductToSave);
                _id = newProductToSave.Id;
                _product = newProductToSave; 
            }
        }
        
        public void SaveAndNew()
        {
            Save();
            New();
        }

        public void New()
        {
            SKU = null;
            Title = null;
            Quantity = 0;
            Price = 0;
            ProductComments = new BindingList<Comment>();
            SearchTitleCategory = string.Empty;
        }

        public void Search()
        {
            Categories = new BindingList<Category>(_categoryRepository.FindBy(x => x.Title.ToLower().StartsWith(_searchTitleCategory.ToLower())).ToList());
        }

        public void AllCategoriesToGrid()
        {
            Categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }
        public string SKU
        {
            get { return _sku; }
            set
            {
                if (value == _sku) return;
                _sku = value;
                NotifyPropertyChanged();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == _title) return;
                _title = value;
                NotifyPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value == _quantity) return;
                _quantity = value;
                NotifyPropertyChanged();
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value.Equals(_price)) return;
                _price = value;
                NotifyPropertyChanged();
            }
        }

        public Category Category
        {
            get { return _category; }
            set
            {
                if (Equals(value, _category)) return;
                _category = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> ProductComments
        {
            get { return _productComments; }
            set
            {
                if (Equals(value, _productComments)) return;
                _productComments = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Category> Categories
        {
            get { return _categories; }
            set
            {
                if (Equals(value, _categories)) return;
                _categories = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> CategoryComments
        {
            get { return _categoryComments; }
            set
            {
                if (value.SequenceEqual(_categoryComments)) return;
                _categoryComments = value;
                NotifyPropertyChanged();
            }
        }

        public string SearchTitleCategory
        {
            get { return _searchTitleCategory; }
            set
            {
                if (_searchTitleCategory.Equals(value)) return;
                _searchTitleCategory = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
            }
        }

        public Category CategoryInUse
        {
            get { return _categoryInUse; }
            set
            {
                _categoryInUse = value; 
                NotifyPropertyChanged();
            }
        }

        private int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
