using Newtonsoft.Json;
using SinusWebShop.Models;



namespace SinusWebShop.Api
{
    public class ApiCaller
    {
        private HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();
            Client.BaseAddress = new Uri("https://dummyjson.com/");
        }

        public async Task<Root> GetProductData(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    return result;
                }
            }
            throw new HttpRequestException("Failed to fetch data!");

        }
    }
}