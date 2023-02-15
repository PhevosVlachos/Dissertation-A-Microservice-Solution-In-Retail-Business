using Microsoft.AspNetCore.Mvc;
using Ordering_System.Services;

namespace Ordering_System.Controllers
{
    public class OrderController : Controller
    {


        private readonly ILogger<OrderController> _logger;
        private readonly IOrderInterface _orders;

        public OrderController(ILogger<OrderController> logger, IOrderInterface products)
        {
            _logger = logger;
            _orders = products;
        }

      

        [HttpPost("CreateOrder")]
        public string MakeOrder()
        {
            _orders.MakeOrder();
            return "Ok";
        }

      



       
    }
}
