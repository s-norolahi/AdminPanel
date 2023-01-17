using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void RemoveOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrder(long id);
        ICollection<Order> GetAllOrders();
        ICollection<Order> GetOrdersForUser(string userId);
        ApplicationUser GetUserForOrder(long id);
        ShippingMethod GetShippingMethodForOrder(long id);
        ICollection<OrderDetail> GetDetailsForOrder(long id);
    }
}
