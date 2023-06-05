

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

        [HttpPost("AddProductsToStock")]
        public string CreateProducts([FromBody] ProductDTO productDTO)
        {
            _products.AddProductsToStock(
                productDTO.Name,
                productDTO.Price,
                productDTO.Quantity,
                productDTO.Description
     );

            return "Done";
        }

        [HttpPost("UpdateProductsByName")]
        public string UpdateProductsByName([FromBody] ProductDTO productDTO)
        {
            _products.UpdateProductsByName(productDTO.Name, productDTO.Price, productDTO.Quantity, productDTO.Description);

            return "Done";
        }

        [HttpPost("DeleteProductById")]
        public string DeleteProducts([FromBody] ProductDTO productDTO)
        {
            _products.DeleteProductsById(productDTO.Id);

            return "Done";
        }

        [HttpPost("DeleteProductByName")]
        public string DeleteProductsByName(ProductDTO productDTO)
        {
            _products.DeleteProductsByName(productDTO.Name, productDTO.Quantity);

            return "Done";
        }



        [HttpPost("RemoveProductEntryByName")]
        public string RemoveProductEntryByName(ProductDTO productDTO)
        {
            _products.RemoveProductEntryByName(productDTO.Name);

            return "Done";
        }


        [HttpPost("RemoveProductEntryById")]
        public string RemoveProductEntryById(ProductDTO productDTO)
        {
            _products.RemoveProductEntryById(productDTO.Id);

            return "Done";
        }


    }
}
