using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoriesRepository: ICategoriesRepository
    {
        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void RemoveCategory(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Update(category);
            context.SaveChanges();
        }

        public Category GetCategory(int id)
        {
            return context.Categories.Find(id);
        }

        public ICollection<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }

        public ICollection<Subcategory> GetSubcategoriesForCategory(int id)
        {
            return context.Subcategories.Where(s => s.CategoryID == id).ToList();
        }

        public ICollection<Product> GetProductsForCategory(int id, int page = 1, int limit = 20)
        {
            return context.Products.Where(p => p.CategoryID == id)
                .Skip((page - 1) * limit).Take(limit)
                .ToList();
        }
    }
}
