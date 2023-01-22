using Domain.Entities;
using Domain.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace WebAPi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly IShippingMethodRepository shippingMethodRepository;
        private readonly IPaymentTypeRepository paymentTypeRepository;

        public OrderController(
               IOrderRepository orderRepository,
               IProductRepository productRepository,
               IShippingMethodRepository shippingMethodRepository,
               IPaymentTypeRepository paymentTypeRepository
              // UserManager<ApplicationUser> userManager
              )
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.shippingMethodRepository = shippingMethodRepository;
            this.paymentTypeRepository = paymentTypeRepository;
            //this.userManager = userManager;
        }

        [HttpGet("{id:required}")]
        public Order GetOrderForId(long id)
        {
            var order = orderRepository.GetOrder(id);

            if (order == null)
            {
                return null;
            }

            order.Details = orderRepository.GetDetailsForOrder(id);
            order.ShippingMethod = shippingMethodRepository.GetShippingMethod(order.ShippingMethodID);

            foreach (var detail in order.Details)
            {
                detail.Product = productRepository.GetProduct(detail.ProductID);
            }

            return order;
        }

        [HttpPost]
        public async Task<Order> Index([FromBody] CartDTO cart)
        {
            var orderToAdd = new Order
            {
                //ApplicationUserID = (await userManager.FindByNameAsync(cart.Username)).Id,
                ShippingMethodID = cart.ShippingMethodID,
                Note = cart.Note,
                DateAndTime = DateTime.Now,
                Details = new List<OrderDetail>(),
                ShippingMethodPrice = shippingMethodRepository.GetShippingMethod(cart.ShippingMethodID).Price
            };


            foreach (var item in cart.CartItems)
            {
                if (!productRepository.CheckIfProductIsAvailable(item.ProductID, item.Quantity))
                {
                    return null;
                }

                orderToAdd.Details.Add(new OrderDetail
                {
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = productRepository.GetProduct(item.ProductID).Price,
                    Product = productRepository.GetProduct(item.ProductID)
                });
            }

            orderRepository.AddOrder(orderToAdd);

            foreach (var detail in orderToAdd.Details)
            {
                var product = detail.Product;
                product.AvailableQuantity -= detail.Quantity;

                productRepository.UpdateProduct(product);
            }

            return orderToAdd;
        }

        [HttpGet("last")]
        public List<Product> GetLastOrderedProducts()
        {
            var lastOrders = orderRepository.GetAllOrders().Take(3);

            var productsToReturn = new List<Product>();

            var orders = lastOrders.ToList();
            if (orders.Any())
            {
                foreach (var order in orders)
                {
                    foreach (var detail in orderRepository.GetDetailsForOrder(order.ID))
                    {
                        productsToReturn.Add(
                            productRepository.GetProduct(detail.ProductID));
                    }
                }
            }

            return productsToReturn.Take(4).ToList();
        }

        [HttpGet("shipping-methods")]
        public List<ShippingMethod> GetShippingMethods()
        {
            return shippingMethodRepository.GetAllShippingMethods().ToList();
        }

        [HttpGet("payment-types")]
        public List<PaymentType> GetPaymentTypes()
        {
            return paymentTypeRepository.GetAllPaymentTypes().ToList();
        }

        //[HttpPost("history")]
        //public async Task<List<Order>> OrderHistory([FromBody] UserDTO user)
        //{
        //    var retrievedUser = await userManager.FindByNameAsync(user.Username);

        //    return orderRepository.GetOrdersForUser(retrievedUser.Id).ToList();
        //}
    }
}

