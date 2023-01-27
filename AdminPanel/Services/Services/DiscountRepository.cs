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
    public class DiscountRepository//: IDiscountRepository
    {
        /*
        private ApplicationDbContext context;

        public DiscountRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddDiscount(Discount discount)
        {
            context.Discounts.Add(discount);
            context.SaveChanges();
        }

        public void RemoveDiscount(Discount discount)
        {
            context.Discounts.Remove(discount);
            context.SaveChanges();
        }

        public void UpdateDiscount(Discount discount)
        {
            context.Discounts.Update(discount);
            context.SaveChanges();
        }

        public Discount GetDiscount(long id)
        {
            return context.Discounts.Find(id);
        }

        public ICollection<Discount> GetAllDiscounts()
        {
            return context.Discounts.ToList();
        }

        public Product GetProductForDiscount(long id)
        {
            return context.Discounts.Find(id)?.Product;
        }
        */
    }
}
