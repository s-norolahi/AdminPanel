using AutoMapper;
using Domain.Entities;
using InfraStructure;
using InfraStructure.Contracts;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class OrderRepository : IBaseSevice, IOrderRepository
    {
        private readonly IRepository<Order> _orderRepository;
        protected readonly IMapper _mapper;

        public OrderRepository(IRepository<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<Order> AddOrderAsync(Order order, CancellationToken cancellationToken)
        {
            await _orderRepository.AddAsync(order, cancellationToken);
            return order;
        }
        public async Task<Order> UpdateOrderAsync(Order order, CancellationToken cancellationToken)
        {
            await _orderRepository.UpdateAsync(order, cancellationToken);
            return order;
        }
        public async Task<Order> FindOrderAsync(int id, CancellationToken cancellationToken)
        {
            var cat = await _orderRepository.GetByIdAsync(cancellationToken, id);
            return cat;
        }
        //{
        /*
        private ApplicationDbContext context;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void AddOrder(Order order)
        {
            context.Orders.Add(order);

            foreach (var orderDetail in order.Details)
            {
                context.Products.Find(orderDetail.ProductID).AvailableQuantity -= orderDetail.Quantity;
            }

            context.SaveChanges();
        }

        public void RemoveOrder(Order order)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public Order GetOrder(long id)
        {
            return context.Orders.Find(id);
        }

        public ICollection<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }

        public ICollection<Order> GetOrdersForUser(string userId)
        {
            return context.Orders.Where(order => order.ApplicationUserID == userId).ToList();
        }

        //public ApplicationUser GetUserForOrder(long id)
        //{
        //    return (ApplicationUser)context.Users.Find(
        //        context.Orders.Find(id)?.ApplicationUserID
        //    );
        //}

        public ShippingMethod GetShippingMethodForOrder(long id)
        {
            return context.ShippingMethods.Find(
                context.Orders.Find(id)?.ShippingMethodID
            );
        }

        public ICollection<OrderDetail> GetDetailsForOrder(long id)
        {
            return context.OrderDetails.Where(od => od.OrderID == id).ToList();
        }
        */
    }
}
