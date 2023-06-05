using Cart_System.Model;
using Cart_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cart_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly ICartService _cart;

        public CartController(ILogger<CartController> logger, ICartService cart)
        {
            _logger = logger;
            _cart = cart;
        }


        [HttpPost("CreateCart")]
        public string CreateCart(int customerId) {

            _cart.CreateCart(customerId);

            return "Done";

        }



        [HttpPost("AddProductToCart")]
        public void AddProductToCart(int customerId, int productId, int quantity) 
        {

            _cart.AddProductToCart(customerId, productId, quantity);
           

            

        }

        [HttpGet("GetCartDetails/{customerId}")]
            public List<CartDetails> ReadCartDetails(int customerId)
        {

            return _cart.ReadCartDetails(customerId);
        
        
        }

        [HttpGet("GetCustomer/{customerId}")]
        public Account GetCust(int customerId)
        {

            return _cart.GetCustomer(customerId);


        }






    }
}
