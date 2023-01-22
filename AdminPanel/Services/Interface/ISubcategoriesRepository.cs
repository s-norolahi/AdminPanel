using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ISubcategoriesRepository
    {
        void AddSubcategory(Subcategory subcategory);
        void RemoveSubcategory(Subcategory subcategory);
        void UpdateSubcategory(Subcategory subcategory);
        Subcategory GetSubcategory(int id);
        ICollection<Subcategory> GetAllSubcategories();
        Category GetCategoryForSubcategory(int id);
        ICollection<Product> GetProductsForSubcategory(int id, int page = 1, int limit = 20);
    }
}
