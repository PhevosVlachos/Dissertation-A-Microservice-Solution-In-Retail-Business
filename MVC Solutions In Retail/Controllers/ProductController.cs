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

        [HttpGet("GetProducts")]
        public List<Product> GetProducts()
        {
            return _products.ReadProducts();
        }

        [HttpGet("CreateProducts")]
        public string CreateProducts()
        {
            _products.MakeProducts();
            return "Ok";
        }

        [HttpPost("UpdateProduct")]
        public void UpdateProducts([FromBody]ProductDTO productDTO)
        {
            _products.SetProductToSupplier(productDTO.Id, productDTO.SupplierId);
           

        }
    }
}
