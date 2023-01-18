using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IDiscountRepository discountRepository;

        public ProductController(IProductRepository productRepository, IDiscountRepository discountRepository)
        {
            this.productRepository = productRepository;
            this.discountRepository = discountRepository;
        }

        [HttpGet("{id:required}")]
        public Product Index(long id)
        {
            var result = productRepository.GetProduct(id);
            result.Producer = productRepository.GetProducerForProduct(id);
            result.Category = productRepository.GetCategoryForProduct(id);
            result.Subcategory = productRepository.GetSubcategoryForProduct(id);
            result.Discounts = productRepository.GetDiscountsForProduct(id);

            return result;
        }

        [HttpGet("selected")]
        public List<Product> GetSelectedProducts([FromQuery] int[] ids)
        {
            var results = ids?.Select(id => productRepository.GetProduct(id)).ToList();

            foreach (var product in results)
            {
                product.Producer = productRepository.GetProducerForProduct(product.ID);
            }

            return results;
        }

        [HttpGet("discounts")]
        public ICollection<Discount> Discounts()
        {
            return discountRepository.GetAllDiscounts();
        }
    }
}

