using Domain.Entities;
using Domain.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace WebAPi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesRepository categoriesRepository;

        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        [HttpGet]
        public ICollection<Category> Index()
        {
            return categoriesRepository.GetAllCategories();
        }

        [HttpGet("{id:required}")]
        public CategoryPageDTO Category(int id, int? page, int? limit)
        {
            var result = new CategoryPageDTO
            {
                Category = categoriesRepository.GetCategory(id),
                Subcategories = categoriesRepository.GetSubcategoriesForCategory(id),
                Products = categoriesRepository.GetProductsForCategory(id, page ?? 1, limit ?? 20)
            };

            return result;
        }
    }
}
