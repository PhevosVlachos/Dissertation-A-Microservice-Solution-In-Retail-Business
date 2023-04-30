namespace Eshop_Front_End.ClientServices
{
    public class ClientService
    {
        public static T? GetItemAsync<T>()
        {
            string base_url = "https://localhost:7066/Product/";
            string url = "GetAllProducts"; using (HttpClient client = new())
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
