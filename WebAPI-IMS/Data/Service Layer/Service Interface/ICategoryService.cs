using WebAPI_IMS.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Service_Layer.Service_Interfaces
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
    }
}
