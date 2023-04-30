

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MVC_Solutions_In_Retail.DTO;
using MVC_Solutions_In_Retail.Model;
using MVC_Solutions_In_Retail.Services;


namespace MVC_Solutions_In_Retail.Controllers
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



        [HttpGet("GetAllProducts")]
        public List<Product> GetAllProducts()
        {
            return _products.GetAllProducts();
        }

        [HttpPost("CreateProducts")]
        public string CreateProducts([FromBody] ProductDTO productDTO)
        {
            _products.CreateProducts(
                productDTO.Name,
                productDTO.Price);

            return "Done";
        }

        [HttpPost("UpdateProduct")]
        public string UpdateProducts([FromBody] ProductDTO productDTO)
        {
            _products.UpdateProducts(productDTO.Id, productDTO.Price);

            return "Done";
        }

        [HttpPost("DeleteProduct")]
        public string DeleteProducts([FromBody] ProductDTO productDTO)
        {
            _products.DeleteProducts(productDTO.Id);

            return "Done";
        }
    }
}
