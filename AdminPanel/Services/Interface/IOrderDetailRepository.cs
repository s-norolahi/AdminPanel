using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IOrderDetailRepository
    {
        void AddOrderDetail(OrderDetail orderDetail);
        void RemoveOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        OrderDetail GetOrderDetail(long id);
        ICollection<OrderDetail> GetAllOrderDetails();
        Order GetOrderForOrderDetail(long id);
        Product GetProductForOrderDetail(long id);
    }
}
