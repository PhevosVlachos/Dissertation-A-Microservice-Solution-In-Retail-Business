using Ordering_System.ClientServices;
using Ordering_System.Model;
using System.IO;

namespace Ordering_System.Services
{
    public class ProductService : IProductService
    {
        public List<Product> ReadProducts()
        {


            List<Product> products = ProductHandler.GetProductsAsync();


            return products;
        }
    }
}
        