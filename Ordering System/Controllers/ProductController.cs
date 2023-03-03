using Microsoft.AspNetCore.Mvc;
using Ordering_System.Model;
using Ordering_System.Services;

namespace Ordering_System.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _products;

        public ProductController(ILogger<ProductController> logger, IProductService products)
        {
            _logger = logger;
            _products = products;
        }

        [HttpGet("GetProducts")]
        public List<Product> GetProducts()
        {
            return _products.ReadProducts();
        }

      
    }
}
