﻿using Domain.Entities;
using InfraStructure;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class OrderDetailRepository//: IOrderDetailRepository
    {
        /*
        private ApplicationDbContext context;

        public OrderDetailRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }

        public void RemoveOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Remove(orderDetail);
            context.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Update(orderDetail);
            context.SaveChanges();
        }

        public OrderDetail GetOrderDetail(long id)
        {
            return context.OrderDetails.Find(id);
        }

        public ICollection<OrderDetail> GetAllOrderDetails()
        {
            return context.OrderDetails.ToList();
        }

        public Order GetOrderForOrderDetail(long id)
        {
            return context.OrderDetails.Find(id)?.Order;
        }

        public Product GetProductForOrderDetail(long id)
        {
            return context.OrderDetails.Find(id)?.Product;
        }
        */
    }
}
