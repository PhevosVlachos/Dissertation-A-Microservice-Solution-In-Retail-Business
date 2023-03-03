using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Ordering_System.ClientServices
{
    public class ApiCaller
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();

        public static void InitializeClient() {

            ApiClient.BaseAddress = new Uri("http://localhost:64195/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

    }
}
