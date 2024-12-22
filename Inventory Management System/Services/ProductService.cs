//using System.Net.Http;
//using System.Net.Http.Json;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using WebAPI_IMS.

//namespace WebAPI_IMS.Services
//{
//    public class ProductService : IProductService
//    {
//        private readonly HttpClient _httpClient;

//        public ProductService(HttpClient httpClient)
//        {
//            _httpClient = httpClient;
//        }

//        public async Task<IEnumerable<Product>> GetAllProductsAsync()
//        {
//            return await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("Product");
//        }

//        public async Task<Product> GetProductByIdAsync(int id)
//        {
//            return await _httpClient.GetFromJsonAsync<Product>($"Product/{id}");
//        }

//        public async Task AddProductAsync(Product product)
//        {
//            await _httpClient.PostAsJsonAsync("Product", product);
//        }

//        public async Task UpdateProductAsync(int id, Product product)
//        {
//            await _httpClient.PutAsJsonAsync($"Product/{id}", product);
//        }

//        public async Task DeleteProductAsync(int id)
//        {
//            await _httpClient.DeleteAsync($"Product/{id}");
//        }
//    }
//}
