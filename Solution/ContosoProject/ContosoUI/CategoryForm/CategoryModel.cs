using Data.EFRepository;
using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Products;

namespace ContosoUI.CategoryForm
{
    public class CategoryModel:Model
    {
        public CategoryModel()
            :base()
        {

        }

        public ICategoryRepository CategoryRepository 
        {
            get { return Facade.CategoryRepository; } 
        }

        public void Save(Category category)
        {
            CategoryRepository.Update(category);
        }

        public void Create(Category category)
        {
            CategoryRepository.Create(category);
        }

        public Category Find(int id)
        {
            return CategoryRepository.Read(id);
        }
    }
}
