using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("https://dummyjson.com/products");
    }
}

