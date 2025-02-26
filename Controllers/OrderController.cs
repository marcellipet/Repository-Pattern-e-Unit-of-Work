using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Models;
using UnitOfShop.Repositories;

namespace UnitOfShop.Controllers
{
    [ApiController] 
    [Route("v1/orders")]
    public class OrderController : ControllerBase {
        public OrderController Post(
            [FromServices] ICustomerRepository customerRepository,
            [FromServices] IOrderRepository orderRepository

        ){
            try {
                var customer = new Customer { Name = "Customer 1" };
                customerRepository.Save(customer);

                var order = new Order { Customer = customer };
                orderRepository.Save(order);

                return order;
            } catch{
                return null;
            }
        }    
    }
}