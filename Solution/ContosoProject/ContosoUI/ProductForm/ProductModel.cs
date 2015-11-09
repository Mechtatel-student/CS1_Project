using Data.Design;
using Domain.DAO;
using Domain.Entities.Products;
using System.Collections.Generic;

namespace ContosoUI.ProductForm
{
    public class ProductModel: Model
    {
        public ProductModel()
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

        public Product Find(int id)
        {
            return ProductRepository.Read(id);
        }

        public void Save(Product productToSave)
        {
            ProductRepository.Update(productToSave);
        }

        public void Create(Product productToSave)
        {
            ProductRepository.Create(productToSave);
        }

        public ICollection<Product> GetBy(string sku, string title, Category category)
        {
           return ProductRepository.GetBy(sku, title, category);
        }
    }
}
