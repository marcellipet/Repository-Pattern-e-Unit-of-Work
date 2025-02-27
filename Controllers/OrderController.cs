using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories;

namespace UnitOfShop.Controllers
{
    [ApiController] 
    [Route("v1/orders")]
    public class OrderController : ControllerBase {
        public OrderController Post(

            [FromServices] ICustomerRepository customerRepository,
            [FromServices] IOrderRepository orderRepository,
            [FromServices] IUnitOfWork uow
        )
        {
            try{
                var customer = new Customer { Name = "Marcelli Petranela" };
                var order = new Order { Number = "123", Customer = customer };

                customerRepository.Save(customer);
                orderRepository.Save(order);
                
                uow.Commit();

                return order;
           }catch{
                uow.Rollback();
            return null;
           }
        }
    }
}