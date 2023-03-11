using Ordering_System.Model;

namespace Ordering_System.ClientServices
{
    public class ProductHandler
    {

        public static T? GetProductAsync<T>()
        {
            string base_url = "https://localhost:7066/Product/";
            string url = "GetProducts"; using (HttpClient client = new())
            {
                client.BaseAddress = new Uri(base_url);
                var responseTask = client.GetAsync(url);
                responseTask.Wait(); 

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<T>();
                    readTask.Wait();
                    return readTask.Result;
                }
            }
            return default;
        }

    }
}
