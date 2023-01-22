using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ShippingMethodRepository: IShippingMethodRepository
    {
        public void AddShippingMethod(ShippingMethod shippingMethod)
        {
            context.ShippingMethods.Add(shippingMethod);
            context.SaveChanges();
        }

        public void RemoveShippingMethod(ShippingMethod shippingMethod)
        {
            context.ShippingMethods.Remove(shippingMethod);
            context.SaveChanges();
        }

        public void UpdateShippingMethod(ShippingMethod shippingMethod)
        {
            context.ShippingMethods.Update(shippingMethod);
            context.SaveChanges();
        }

        public ShippingMethod GetShippingMethod(int id)
        {
            return context.ShippingMethods.Find(id);
        }

        public ICollection<ShippingMethod> GetAllShippingMethods()
        {
            return context.ShippingMethods.ToList();
        }
    }
}
