using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProduct(long id);
        ICollection<Product> GetAllProducts();
        Producer GetProducerForProduct(long id);
        Category GetCategoryForProduct(long id);
        Subcategory GetSubcategoryForProduct(long id);
        ICollection<Review> GetReviewsForProduct(long id);
        ICollection<Discount> GetDiscountsForProduct(long id);
        bool CheckIfProductIsAvailable(long id, int neededQuantity = 0);
    }
}
