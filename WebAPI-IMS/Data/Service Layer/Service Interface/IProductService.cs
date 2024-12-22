using WebAPI_IMS.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Service_Layer.Service_Interface
{
    public interface IProductService
    {
        Task AddProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task UpdateProductAsync(Product product);

    }
}
