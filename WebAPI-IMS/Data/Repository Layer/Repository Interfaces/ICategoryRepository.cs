using WebAPI_IMS.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Repository_Layer.Repository_Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(Category category);
    }
 }

