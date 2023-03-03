using Ordering_System.Model;

namespace Ordering_System.ClientServices
{
    public class ProductHandler
    {

        public static async Task<List<Product>> GetProductsAsync()
        {
            String path = "https://localhost:7066/company/GetProducts";

            List<Product> products = null;

            HttpResponseMessage response = await ApiCaller.ApiClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsAsync<List<Product>>();
            }
            return products;

        } 

    }
}
