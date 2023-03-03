using Microsoft.AspNetCore.Mvc;
using Ordering_System.DTO;
using Ordering_System.Services;

namespace Ordering_System.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {


        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orders;

        public OrderController(ILogger<OrderController> logger, IOrderService orders)
        {
            _logger = logger;
            _orders = orders;
        }

      

        [HttpPost("CreateOrder")]
        public string MakeOrder([FromBody] ProductDTO productDTO)
        {
            _orders.MakeOrder();
            return "Ok";
        }

      



       
    }
}
