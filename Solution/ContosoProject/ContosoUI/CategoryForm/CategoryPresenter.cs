using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.CategoryForm
{
    public class CategoryPresenter : Presenter
    {
        private readonly ICategoryView _view;
        private readonly CategoryModel _model;

        private readonly ICategoryRepository _categoryRepository;

        private Category _categoryToSave = null;
        private Category _selectedCategory = null;

        private BindingList<Category> _categories;
        private BindingList<Comment> _categoryComments = new BindingList<Comment>();

        public CategoryPresenter(ICategoryView view, CategoryModel model)
        {
            _view = view;
            _model = model;
            _categoryRepository = _model.CategoryRepository;
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        public void UseCategoryWithID(int id)
        {
            if(id != 0)
                _selectedCategory = Categories.FirstOrDefault(categ=> categ.Id == id);
            if(_selectedCategory!= null)
                _categoryComments = new BindingList<Comment>(_selectedCategory.Comments.ToList());
        }

        private void SaveCategory()
        {
            SaveCategoryInUse();
            foreach (var category in _categories)
            {
                if (category.Id != 0)
                {
                    _model.CategoryRepository.Update(category);
                }
                else
                {
                    _model.CategoryRepository.Create(category);
                }
            }
            /*if (_categoryRepository.GetAll().Count() < _categories.Count)
            {
                _categoryRepository.Create(_categoryToSave);
            }
            if (!_categoryRepository.GetAll().ToList().SequenceEqual(_categories))
            {
                foreach (var category in _categories)
                {
                    _categoryRepository.Save(category);
                }
            }*/
        }

        public void SaveCategoryInUse()
        {
            Category categoryToSave = _selectedCategory;
            
            if (_selectedCategory.Id == 0)
            {
                categoryToSave = new Category(_categoryComments)
                {
                    Date = _selectedCategory.Date,
                    Id = _selectedCategory.Id,
                    IsActive = _selectedCategory.IsActive,
                    Title = _selectedCategory.Title
                };
            }
            else
            {
                categoryToSave.Comments = _categoryComments;
                
            }
            _categories[_categories.IndexOf(_categories.First(x => x.Title == categoryToSave.Title))] = categoryToSave;

        }

        public void Save()
        {
            SaveCategory();
        }        

        public void AddCategoryWithTitle(string title)
        {
            _categories.Add(_categoryToSave  = new Category(Domain.Entities.Comments.Comments.Init(Program.AuthUser, "Category")) { Title = title });
            Categories = new BindingList<Category>(_categories);
            if (Categories.Count < 2)
                _selectedCategory = _categoryToSave;
            SaveCategory();
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

        public BindingList<Comment> Comments
        {
            get { return _categoryComments; }
            set
            {
                if (value.SequenceEqual(_categoryComments)) return;
                _categoryComments = value;
                NotifyPropertyChanged();
            }
        }

        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
