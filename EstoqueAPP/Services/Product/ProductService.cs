using EstoqueAPP.DTO.Requests;
using System.Net.Http.Json;

namespace EstoqueAPP.Services.Product
{
    internal class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task RegisterProduct(RegisterProductDTO product)
        {
            await _httpClient.PostAsJsonAsync("register", product);
        }
    }
}
