using Domain.Common;
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
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        [HttpGet]
        public async Task<PagedList<CateGoryGridView>> Index(CancellationToken cancellationToken, string name, int pageNumber=0,int pagesize=10)
        {
            return await _categoriesRepository.GetAll(pageNumber,pagesize,name,cancellationToken);
        }
        [HttpPost("create")]
        public  async Task<ActionResult<Category>> Post(Category category, CancellationToken cancellationToken)
        {            
            return Ok(await _categoriesRepository.AddCategoryAsync(category, cancellationToken));
        }
        [HttpPut("update")]
        public async Task<ActionResult<Category>> Put(Category category, CancellationToken cancellationToken)
        {
            return Ok(await _categoriesRepository.UpdateCategoryAsync(category, cancellationToken));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id, CancellationToken cancellationToken)
        {
            return Ok(await _categoriesRepository.FindCategoryAsync(id, cancellationToken));
        }
        //[HttpGet("{id:required}")]
        //public CategoryPageDTO Category(int id, int? page, int? limit)
        //{
        //    var result = new CategoryPageDTO
        //    {
        //        Category = _categoriesRepository.GetCategory(id),
        //        Subcategories = _categoriesRepository.GetSubcategoriesForCategory(id),
        //        Products = _categoriesRepository.GetProductsForCategory(id, page ?? 1, limit ?? 20)
        //    };

        //    return result;
        //}
    }
}
