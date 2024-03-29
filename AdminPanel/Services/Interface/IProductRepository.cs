﻿using Domain.Common;
using Domain.Entities;
using Domain.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProductRepository
    {
        Task<PagedList<ProductGridView>> GetAll(int pageNumber, int pageSize, string name, CancellationToken cancellationToken);
        Task<Product> AddProductAsync(Product product, CancellationToken cancellationToken);
        Task<Product> FindProductAsync(int id, CancellationToken cancellationToken);
        Task<Product> UpdateProductAsync(Product product, CancellationToken cancellationToken);

        //void AddProduct(Product product);
        //void RemoveProduct(Product product);
        //void UpdateProduct(Product product);
        //Product GetProduct(long id);
        //ICollection<Product> GetAllProducts();
        //Producer GetProducerForProduct(long id);
        //Category GetCategoryForProduct(long id);
        //Subcategory GetSubcategoryForProduct(long id);
        //ICollection<Review> GetReviewsForProduct(long id);
        //ICollection<Discount> GetDiscountsForProduct(long id);
        //bool CheckIfProductIsAvailable(long id, int neededQuantity = 0);
    }
}
