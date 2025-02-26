using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Models;

namespace UnitOfShop.Controllers
{
    [ApiController] 
    [Route("v1/orders")]
    public class OrderController : ControllerBase {
        public OrderController Post(

        ){
            var customer = new Customer{Name = "Marcelli"};
            var order = new Order{Number = "123", Customer = customer};       
        }
    }
}