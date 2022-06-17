using System.Net.Http.Headers;

namespace FarmCentralMvcFrontEnd
{
    public static class Helper
    {
        public static HttpClient WebApiClient = new HttpClient();

        static Helper()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:58898"); 
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
