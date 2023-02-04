using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace WebAPi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //[HttpGet]
        //public async Task<PagedList<CateGoryGridView>> Index(CancellationToken cancellationToken, string name, int pageNumber = 0, int pagesize = 10)
        //{
        //    return await _categoriesRepository.GetAll(pageNumber, pagesize, name, cancellationToken);
        //}
        [HttpPost("create")]
        public async Task<ActionResult<Product>> Post(Product order, CancellationToken cancellationToken)
        {
            return Ok(await _productRepository.AddProductAsync(order, cancellationToken));
        }
        [HttpPut("update")]
        public async Task<ActionResult<Product>> Put(Product category, CancellationToken cancellationToken)
        {
            return Ok(await _productRepository.UpdateProductAsync(category, cancellationToken));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id, CancellationToken cancellationToken)
        {
            return Ok(await _productRepository.FindProductAsync(id, cancellationToken));
        }
        //[HttpGet("{id:required}")]
        //public Product Index(long id)
        //{
        //    var result = productRepository.GetProduct(id);
        //    result.Producer = productRepository.GetProducerForProduct(id);
        //    result.Category = productRepository.GetCategoryForProduct(id);
        //    result.Subcategory = productRepository.GetSubcategoryForProduct(id);
        //    result.Discounts = productRepository.GetDiscountsForProduct(id);

        //    return result;
        //}

        //[HttpGet("selected")]
        //public List<Product> GetSelectedProducts([FromQuery] int[] ids)
        //{
        //    var results = ids?.Select(id => productRepository.GetProduct(id)).ToList();

        //    foreach (var product in results)
        //    {
        //        product.Producer = productRepository.GetProducerForProduct(product.ID);
        //    }

        //    return results;
        //}

        //[HttpGet("discounts")]
        //public ICollection<Discount> Discounts()
        //{
        //    return discountRepository.GetAllDiscounts();
        //}
    }
}

