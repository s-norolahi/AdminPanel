using Domain.Common;
using Domain.Entities;
using Domain.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IOrderRepository
    {
        //Task<PagedList<CateGoryGridView>> GetAll(int pageNumber, int pageSize, string name, CancellationToken cancellationToken);
        Task<Order> AddOrderAsync(Order order, CancellationToken cancellationToken);
        Task<Order> FindOrderAsync(int id, CancellationToken cancellationToken);
        Task<Order> UpdateOrderAsync(Order order, CancellationToken cancellationToken);
        //void AddOrder(Order order);
        //void RemoveOrder(Order order);
        //void UpdateOrder(Order order);
        //Order GetOrder(long id);
        //ICollection<Order> GetAllOrders();
        //ICollection<Order> GetOrdersForUser(string userId);
        ////ApplicationUser GetUserForOrder(long id);
        //ShippingMethod GetShippingMethodForOrder(long id);
        //ICollection<OrderDetail> GetDetailsForOrder(long id);
    }
}
