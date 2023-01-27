using Domain.Entities;
using InfraStructure;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductRepository//: IProductRepository
    {
        /*
        private ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void RemoveProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public Product GetProduct(long id)
        {
            return context.Products.Find(id);
        }

        public ICollection<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Producer GetProducerForProduct(long id)
        {
            return context.Producers.Find(
                context.Products.Find(id)?.ProducerID
            );
        }

        public Category GetCategoryForProduct(long id)
        {
            return context.Categories.Find(
                context.Products.Find(id)?.CategoryID
            );
        }

        public Subcategory GetSubcategoryForProduct(long id)
        {
            return context.Subcategories.Find(
                context.Products.Find(id)?.SubcategoryID
            );
        }

        public ICollection<Review> GetReviewsForProduct(long id)
        {
            return context.Reviews.Where(r => r.ProductID == id).ToList();
        }

        public ICollection<Discount> GetDiscountsForProduct(long id)
        {
            return context.Discounts.Where(d => d.ProductID == id).ToList();
        }

        public bool CheckIfProductIsAvailable(long id, int neededQuantity = 0)
        {
            return context.Products.Find(id).AvailableQuantity > neededQuantity;
        }
        */
    }
}
