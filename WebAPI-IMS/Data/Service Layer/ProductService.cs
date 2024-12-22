using WebAPI_IMS.Data.Entities;
using WebAPI_IMS.Data.Repository_Layer.Repository_Interfaces;
using WebAPI_IMS.Data.Service_Layer.Service_Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_IMS.Data.Service_Layer.Service_Interface;

namespace WebAPI_IMS.Data.Service_Layer
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        // Constructor to inject the repository
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateProductAsync(product);
        }
    }
}
