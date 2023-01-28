using Domain.Common;
using Domain.Entities;
using Domain.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICategoriesRepository
    {
        Task<PagedList<CateGoryGridView>> GetAll(int pageNumber, int pageSize, string name, CancellationToken cancellationToken);
        Task<Category> AddCategoryAsync(Category category, CancellationToken cancellationToken);
        Task<Category> FindCategoryAsync(int id, CancellationToken cancellationToken);
        Task<Category> UpdateCategoryAsync(Category category, CancellationToken cancellationToken);
        //void AddCategory(Category category);
        //void RemoveCategory(Category category);
        //void UpdateCategory(Category category);
        //Category GetCategory(int id);
        //ICollection<Category> GetAllCategories();
        //ICollection<Subcategory> GetSubcategoriesForCategory(int id);
        //ICollection<Product> GetProductsForCategory(int id, int page = 1, int limit = 20);
    }
}
