using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDiscountRepository
    {
        void AddDiscount(Discount discount);
        void RemoveDiscount(Discount discount);
        void UpdateDiscount(Discount discount);
        Discount GetDiscount(long id);
        ICollection<Discount> GetAllDiscounts();
        Product GetProductForDiscount(long id);
    }
}
