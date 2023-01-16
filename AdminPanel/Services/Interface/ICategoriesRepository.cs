using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICategoriesRepository
    {
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategory(int id);
        ICollection<Category> GetAllCategories();
        ICollection<Subcategory> GetSubcategoriesForCategory(int id);
        ICollection<Product> GetProductsForCategory(int id, int page = 1, int limit = 20);
    }
}
