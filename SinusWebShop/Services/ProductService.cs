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

    public async Task<List<Product>> GetProductsByCategoryAsync(string categoryName)
    {
        var allProducts = await _httpClient.GetFromJsonAsync<List<Product>>("https://dummyjson.com/docs/products");
        return allProducts.Where(p => p.Category == categoryName).ToList();
    }

}
