using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IShippingMethodRepository
    {
        void AddShippingMethod(ShippingMethod shippingMethod);
        void RemoveShippingMethod(ShippingMethod shippingMethod);
        void UpdateShippingMethod(ShippingMethod shippingMethod);
        ShippingMethod GetShippingMethod(int id);
        ICollection<ShippingMethod> GetAllShippingMethods();
    }
}
