using Ordering_System.Client;
using Ordering_System.Model;
using System.IO;

namespace Ordering_System.Services
{
    public class ProductService : IProductService
    {
        public List<Product> ReadProducts()
        {


            List<Product> products = ApiCaller.GetItemAsync<List<Product>>("https://localhost:7066/Product/", "GetAllProducts");


            return products;
        }
    }
}
        